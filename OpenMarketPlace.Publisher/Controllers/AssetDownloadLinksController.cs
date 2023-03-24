using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands;
using OpenMarketPlace.Publisher.CQRS.AssetDownloadLinkCQRS;
using OpenMarketPlace.Publisher.CQRS.PublisherCQRS.Queries;
using OpenMarketPlace.Publisher.Dtos.AssetDownLoadLinkDtos;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;
using System.Security.Claims;

namespace OpenMarketPlace.Publisher.Controllers
{
    [Authorize]
    public class AssetDownloadLinksController : Controller
    {
        private readonly IMediator _mediator;

        private readonly UserManager<ApplicationUser> _userManager;

        public AssetDownloadLinksController(IMediator mediator, UserManager<ApplicationUser> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAssetDownloadLinkDto createAssetDownloadLinkDto)
        {
            // get logged=in id
            var applicationUser = await _userManager.GetUserAsync(User);

            // update dto with data
            if (applicationUser == null)
            {
                ModelState.AddModelError("CreatedById", "Logged in user-id could not be established");
            }

            // update dto with data
            createAssetDownloadLinkDto.CreatedById = applicationUser.Id;

            if (ModelState.IsValid)
            {
                // save new asset
                var assetDownloadLink = await _mediator.Send(new CreateAssetDownloadLinkCommand()
                {
                    AssetDownloadLink = createAssetDownloadLinkDto
                });

                // redirect to edit page
                return Ok(assetDownloadLink);
            }
            else
            {
                // return view
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Disable(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Enable(int id)
        {
            return Ok();
        }
    }
}
