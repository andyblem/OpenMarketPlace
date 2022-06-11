﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Store.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Store.CQRS.AssetsCQRS
{
    public class GetRecentlyUpdatedAssetsQuery : IRequest<IEnumerable<IndexAssetDto>>
    {
        public int Amount { get; set; }
    }

    public class GetRecentlyUpdatedAssetsQueryHandler : IRequestHandler<GetRecentlyUpdatedAssetsQuery, IEnumerable<IndexAssetDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetRecentlyUpdatedAssetsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexAssetDto>> Handle(GetRecentlyUpdatedAssetsQuery request, CancellationToken cancellationToken)
        {
            // get data
            var RecentlyUpdatedAssets = await _dbContext.Assets
                .Where(a => a.AssetReleaseStateId == AssetReleaseStateEnums.Released)
                .OrderBy(a => a.LastUpdatedAt)
                .Take(request.Amount)
                .Select(a => new IndexAssetDto()
                {
                    Id = a.Id,
                    Rating = a.Rating,
                    Reviews = a.Reviews,

                    AssetType = a.AssetType.Name,
                    IconImagePath = a.AssetResource.IconImage,
                    Name = a.Name,
                    Publisher = a.Publisher.Name
                })
                .ToListAsync();

            // return result
            return RecentlyUpdatedAssets;
        }
    }
}
