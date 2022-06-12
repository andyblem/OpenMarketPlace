using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Models;

namespace Stride3DMarketPlace.Seller.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _dbContext = dbContext;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            public bool IsAgreeingToPublisherTermsOfService { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                // if user with email already exists
                    // add publisher role to user if not added and add publisher profile
                // else add new user, publisher role and profile

                
                var existingUser = await _userManager.FindByEmailAsync(Input.Email);
                if (existingUser == null)
                {
                    // create user
                    var newUser = new ApplicationUser { 
                        UserName = Input.Email, 
                        Email = Input.Email,
                        IsAgreeingToPublisherTermsOfService = Input.IsAgreeingToPublisherTermsOfService
                    };

                    // save user
                    var result = await _userManager.CreateAsync(newUser, Input.Password);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User created a new account with password.");

                        // add publisher role to user
                        await _userManager.AddToRoleAsync(newUser, "Publisher");

                        // create and save publisher
                        var newPublisher = new Publisher()
                        {
                            Name = Input.Name,
                        };
                        _dbContext.Add(newPublisher);
                        await _dbContext.SaveChangesAsync();

                        // add publisher profile to user
                        newUser.PublisherId = newPublisher.Id;
                        await _userManager.UpdateAsync(newUser);

                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { area = "Identity", userId = newUser.Id, code = code, returnUrl = returnUrl },
                            protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                        if (_userManager.Options.SignIn.RequireConfirmedAccount)
                        {
                            return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                        }
                        else
                        {
                            await _signInManager.SignInAsync(newUser, isPersistent: false);
                            return LocalRedirect(returnUrl);
                        }
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                else
                {
                    var userRoleExists = _userManager.IsInRoleAsync(existingUser, "Publisher");
                    if(userRoleExists == null)
                    {
                        // add publisher role to user
                        await _userManager.AddToRoleAsync(existingUser, "Publisher");

                        // create and save publisher
                        var newPublisher = new Publisher()
                        {
                            Name = Input.Name,
                        };
                        _dbContext.Add(newPublisher);
                        await _dbContext.SaveChangesAsync();

                        // add publisher profile to user
                        existingUser.IsAgreeingToPublisherTermsOfService = Input.IsAgreeingToPublisherTermsOfService;
                        existingUser.PublisherId = newPublisher.Id;
                        await _userManager.UpdateAsync(existingUser);
                    }
                    else
                    {
                        // add error
                        ModelState.AddModelError("Exists",
                            "Publisher account already exists");
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
