using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OpenMarketPlace.Persistance.Enums;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.CQRS.AssetCategoryCQRS.Queries;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Queries;
using OpenMarketPlace.Publisher.CQRS.EngineVersionCQRS.Queries;
using OpenMarketPlace.Publisher.CQRS.PublisherCQRS.Queries;
using OpenMarketPlace.Publisher.CQRS.TagsCQRS.Queries;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;
using System.Security.Claims;

namespace OpenMarketPlace.Publisher.Controllers
{
    [Authorize]
    public class AssetsController : Controller
    {
        private readonly IMediator _mediator;

        private readonly UserManager<ApplicationUser> _userManager;


        public AssetsController(IMediator mediator, UserManager<ApplicationUser> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }

        // GET: Assets
        public async Task<IActionResult> Index(AssetStatusEnums? assetReleaseStateId)
        {
            // get logged in user publisher-id
            var isInPublisherRole = User.IsInRole("Publisher");
            if (isInPublisherRole == true)
            {
                // get publisher id
                var applicationUser = await _userManager.GetUserAsync(User);
                var publisherId = applicationUser.PublisherId;

                // get assets data
                var assets = await _mediator.Send(new GetIndexAssetsQuery()
                {
                    AssetReleaseStateId = assetReleaseStateId,
                    PublisherId = publisherId
                });


                // get some other data
                var assetCategories = await _mediator.Send(new GetAssetCategoriesSelectItemsQuery());

                // init view data
                ViewData["AssetCategoryId"] = new SelectList(assetCategories, "Id", "Name");


                // return results
                return View(assets);
            }
            else
            {

                // set view bag data
                TempData["ErrorMessage"] = "Could not match logged in user to publisher profile";

                // return view
                return StatusCode(500);

            }

        }

        // GET: Assets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return null;

            //if (id == null || _context.Assets == null)
            //{
            //    return NotFound();
            //}

            //var Assets = await _context.Assets
            //    .Include(a => a.AssetReleaseState)
            //    .Include(a => a.AssetResource)
            //    .Include(a => a.AssetType)
            //    .Include(a => a.CreatedBy)
            //    .Include(a => a.Publisher)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (Assets == null)
            //{
            //    return NotFound();
            //}

            //return View(Assets);
        }

        //// GET: Assets/Create
        //public IActionResult Create()
        //{
        //    ViewData["AssetReleaseStateId"] = new SelectList(_context.Set<AssetReleaseState>(), "Id", "Name");
        //    ViewData["AssetResourceId"] = new SelectList(_context.Set<AssetResource>(), "Id", "BannerImage");
        //    ViewData["AssetTypeId"] = new SelectList(_context.Set<AssetType>(), "Id", "Name");
        //    ViewData["CreatedById"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
        //    ViewData["EngineVersions"] = new SelectList(_context.Set<EngineVersion>(), "Id", "Name");
        //    ViewData["Keywords"] = new SelectList(_context.Set<Tag>(), "Id", "Name");
        //    ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "Name");

        //    // return result
        //    return View();
        //}

        // POST: Assets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAssetDto createAssetDto)
        {
            // get user id
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var publisherId = await _mediator.Send(new GetUserPublisherIdQuery()
            {
                UserId = userId
            });

            // update dto with data
            if (userId == null)
            {
                ModelState.AddModelError("CreatedById", "Logged in user-id could not be established");
            }
            if (publisherId == null)
            {
                ModelState.AddModelError("PublisherId", "Publisher profile could not be established");
            }

            // update dto with data
            createAssetDto.CreatedById = userId;
            createAssetDto.PublisherId = publisherId;
            createAssetDto.Version = "1.0.0";

            if (ModelState.IsValid)
            {
                // save new asset
                var asset = await _mediator.Send(new CreateAssetCommand()
                {
                    Asset = createAssetDto
                });

                // redirect to edit page
                return Ok(asset);
            }
            else
            {
                // return view
                return BadRequest(ModelState);
            }
        }

        // GET: Assets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            // check if id data is valid
            if (id == null)
            {
                return NotFound();
            }

            // get asset
            var asset = await _mediator.Send(new GetAssetForEditQuery()
            {
                Id = id
            });

            // check if we have an asset
            if (asset == null)
            {
                return NotFound();
            }

            // set view data
            //ViewData["AssetReleaseStateId"] = new SelectList(_context.Set<AssetReleaseState>(), "Id", "Name", asset.AssetReleaseStateId);
            //ViewData["AssetResourceId"] = new SelectList(_context.Set<AssetResource>(), "Id", "BannerImage", asset.AssetResourceId);

            var assetCategories = await _mediator.Send(new GetAssetCategoriesSelectItemsQuery());
            var engineVersions = await _mediator.Send(new GetEngineVersionSelectItemsQuery());
            var tags = await _mediator.Send(new GetTagsSelectItemsQuery());

            ViewData["AssetCategoryId"] = new SelectList(assetCategories, "Id", "Name", asset.AssetCategoryId);
            ViewData["EngineVersionId"] = new MultiSelectList(engineVersions, "Id", "Name", asset.EngineCompatibility);
            ViewData["TagId"] = new MultiSelectList(tags, "Id", "Name", asset.Keywords);

            //ViewData["CreatedById"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", asset.CreatedById);
            //ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "Name", asset.PublisherId);

            // return view
            return View(asset);
        }

        // POST: Assets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Rating,Reviews,Description,EngineCompatibility,GitRepository,LatestVersion,License,NugetPackage,LastUpdatedAt,ReleasedAt,AssetReleaseStateId,AssetTypeId,AssetResourceId,CreatedById,PublisherId,Name,IsDeleted,IsModified,Id,CreatedAt,DeletedAt,ModifiedAt,DeletedById,ModifiedById")] Asset Assets)
        {
            return null;

            //if (id != Assets.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(Assets);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!AssetExists(Assets.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["AssetReleaseStateId"] = new SelectList(_context.Set<AssetReleaseState>(), "Id", "Name", Assets.AssetReleaseStateId);
            //ViewData["AssetResourceId"] = new SelectList(_context.Set<AssetResource>(), "Id", "BannerImage", Assets.AssetResourceId);
            //ViewData["AssetTypeId"] = new SelectList(_context.Set<AssetType>(), "Id", "Name", Assets.AssetTypeId);
            //ViewData["CreatedById"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", Assets.CreatedById);
            //ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "Name", Assets.PublisherId);
            //return View(Assets);
        }

        // GET: Assets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return null;

            //if (id == null || _context.Assets == null)
            //{
            //    return NotFound();
            //}

            //var Assets = await _context.Assets
            //    .Include(a => a.AssetReleaseState)
            //    .Include(a => a.AssetResource)
            //    .Include(a => a.AssetType)
            //    .Include(a => a.CreatedBy)
            //    .Include(a => a.Publisher)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (Assets == null)
            //{
            //    return NotFound();
            //}

            //return View(Assets);
        }

        // POST: Assets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return null;

            //if (_context.Assets == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Assets'  is null.");
            //}
            //var Assets = await _context.Assets.FindAsync(id);
            //if (Assets != null)
            //{
            //    _context.Assets.Remove(Assets);
            //}

            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateDescriptionDetails(UpdateAssetDescriptionDetailsDto updateAssetDescriptionDetailsDto)
        {
            if (ModelState.IsValid)
            {
                // update asset
                var asset = await _mediator.Send(new UpdateAssetDescriptionDetailsCommand()
                {
                    AssetDescriptionDetails = updateAssetDescriptionDetailsDto
                });

                // return result
                return Ok(asset);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateReleaseDetails(UpdateAssetReleaseDetailsDto UpdateReleaseDetailsDto)
        {
            if (ModelState.IsValid)
            {
                // update asset
                var asset = await _mediator.Send(new UpdateAssetReleaseDetailsCommand()
                {
                    AssetReleaseDetails = UpdateReleaseDetailsDto
                });

                // return result
                return Ok(asset);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
