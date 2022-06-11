using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Persistance.Models;
using Stride3DMarketPlace.Seller.CQRS.AssetCQRS;

namespace Stride3DMarketPlace.Seller.Controllers
{
    [Authorize]
    public class AssetsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMediator _mediator;

        public AssetsController(ApplicationDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        // GET: Assets
        public async Task<IActionResult> Index()
        {
            // get data
            var assets = await _mediator.Send(new GetIndexAssetsQuery()
            {
                AssetReleaseStateId = AssetReleaseStateEnums.Released,
                PublisherId = 1
            });

            // return results
            return View(assets);
        }

        // GET: Assets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Assets == null)
            {
                return NotFound();
            }

            var Assets = await _context.Assets
                .Include(a => a.AssetReleaseState)
                .Include(a => a.AssetResource)
                .Include(a => a.AssetType)
                .Include(a => a.CreatedBy)
                .Include(a => a.Publisher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Assets == null)
            {
                return NotFound();
            }

            return View(Assets);
        }

        // GET: Assets/Create
        public IActionResult Create()
        {
            ViewData["AssetReleaseStateId"] = new SelectList(_context.Set<AssetReleaseState>(), "Id", "Name");
            ViewData["AssetResourceId"] = new SelectList(_context.Set<AssetResource>(), "Id", "BannerImage");
            ViewData["AssetTypeId"] = new SelectList(_context.Set<AssetType>(), "Id", "Name");
            ViewData["CreatedById"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "Name");
            return View();
        }

        // POST: Assets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Rating,Reviews,Description,EngineCompatibility,GitRepository,LatestVersion,License,NugetPackage,LastUpdatedAt,ReleasedAt,AssetReleaseStateId,AssetTypeId,AssetResourceId,CreatedById,PublisherId,Name,IsDeleted,IsModified,Id,CreatedAt,DeletedAt,ModifiedAt,DeletedById,ModifiedById")] Asset Assets)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Assets);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AssetReleaseStateId"] = new SelectList(_context.Set<AssetReleaseState>(), "Id", "Name", Assets.AssetReleaseStateId);
            ViewData["AssetResourceId"] = new SelectList(_context.Set<AssetResource>(), "Id", "BannerImage", Assets.AssetResourceId);
            ViewData["AssetTypeId"] = new SelectList(_context.Set<AssetType>(), "Id", "Name", Assets.AssetTypeId);
            ViewData["CreatedById"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", Assets.CreatedById);
            ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "Name", Assets.PublisherId);
            return View(Assets);
        }

        // GET: Assets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Assets == null)
            {
                return NotFound();
            }

            var Assets = await _context.Assets.FindAsync(id);
            if (Assets == null)
            {
                return NotFound();
            }
            ViewData["AssetReleaseStateId"] = new SelectList(_context.Set<AssetReleaseState>(), "Id", "Name", Assets.AssetReleaseStateId);
            ViewData["AssetResourceId"] = new SelectList(_context.Set<AssetResource>(), "Id", "BannerImage", Assets.AssetResourceId);
            ViewData["AssetTypeId"] = new SelectList(_context.Set<AssetType>(), "Id", "Name", Assets.AssetTypeId);
            ViewData["CreatedById"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", Assets.CreatedById);
            ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "Name", Assets.PublisherId);
            return View(Assets);
        }

        // POST: Assets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Rating,Reviews,Description,EngineCompatibility,GitRepository,LatestVersion,License,NugetPackage,LastUpdatedAt,ReleasedAt,AssetReleaseStateId,AssetTypeId,AssetResourceId,CreatedById,PublisherId,Name,IsDeleted,IsModified,Id,CreatedAt,DeletedAt,ModifiedAt,DeletedById,ModifiedById")] Asset Assets)
        {
            if (id != Assets.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Assets);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetExists(Assets.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AssetReleaseStateId"] = new SelectList(_context.Set<AssetReleaseState>(), "Id", "Name", Assets.AssetReleaseStateId);
            ViewData["AssetResourceId"] = new SelectList(_context.Set<AssetResource>(), "Id", "BannerImage", Assets.AssetResourceId);
            ViewData["AssetTypeId"] = new SelectList(_context.Set<AssetType>(), "Id", "Name", Assets.AssetTypeId);
            ViewData["CreatedById"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", Assets.CreatedById);
            ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "Name", Assets.PublisherId);
            return View(Assets);
        }

        // GET: Assets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Assets == null)
            {
                return NotFound();
            }

            var Assets = await _context.Assets
                .Include(a => a.AssetReleaseState)
                .Include(a => a.AssetResource)
                .Include(a => a.AssetType)
                .Include(a => a.CreatedBy)
                .Include(a => a.Publisher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Assets == null)
            {
                return NotFound();
            }

            return View(Assets);
        }

        // POST: Assets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Assets == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Assets'  is null.");
            }
            var Assets = await _context.Assets.FindAsync(id);
            if (Assets != null)
            {
                _context.Assets.Remove(Assets);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetExists(int id)
        {
          return (_context.Assets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
