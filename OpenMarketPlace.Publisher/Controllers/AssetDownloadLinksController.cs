using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands;
using OpenMarketPlace.Publisher.CQRS.AssetDownloadLinkCQRS;
using OpenMarketPlace.Publisher.CQRS.AssetDownloadLinkCQRS.Commands;
using OpenMarketPlace.Publisher.CQRS.AssetDownloadLinkCQRS.Queries;
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

        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            // check id validity
            if (id == null || id <= 0)
            {
                // add error
                ModelState.AddModelError("id", "Invalid Id passed to the server");

                // return result
                return BadRequest(ModelState);
            }

            // get record
            var assetDownloadLink = await _mediator.Send(new GetAssetDownloadLinkQuery() 
            { 
                Id = id 
            });

            // check if it exists
            if(assetDownloadLink == null)
                return NotFound();

            // delete link
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            assetDownloadLink.DeletedById = userId; 
            var result = await _mediator.Send(new DeleteAssetDownloadLinkCommand()
            {
                AssetDownloadLink = assetDownloadLink
            });

            //return result
            if(result == true)
                return Ok();
            else
                return Problem("Entity set 'ApplicationDbContext.AssetDownloadLinks'  is null.");
        }

    }
}
