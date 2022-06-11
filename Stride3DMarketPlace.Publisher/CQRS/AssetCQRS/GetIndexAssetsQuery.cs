using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Seller.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Seller.CQRS.AssetCQRS
{
    public class GetIndexAssetsQuery : IRequest<IEnumerable<IndexAssetDto>>
    {
        public int PublisherId { get; set; }

        public AssetReleaseStateEnums? AssetReleaseStateId { get; set; }
    }

    public class GetIndexAssetsQueryHandler : IRequestHandler<GetIndexAssetsQuery, IEnumerable<IndexAssetDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetIndexAssetsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexAssetDto>> Handle(GetIndexAssetsQuery request, CancellationToken cancellationToken)
        {
            // dynamic queryable
            var getAssetsQuery = _dbContext.Assets.AsQueryable();

            // add conditions
            if (request.AssetReleaseStateId == null)
            {
                getAssetsQuery = getAssetsQuery.Where(a => a.PublisherId == request.PublisherId);
            } 
            else
            {
                getAssetsQuery = getAssetsQuery.Where(a => a.PublisherId == request.PublisherId
                    && a.AssetReleaseStateId == request.AssetReleaseStateId);
            }

            // get data
            var assets = await getAssetsQuery
                .Select(a => new IndexAssetDto()
                {
                    Id = a.Id,
                    Rating = a.Rating,

                    AssetType = a.AssetType.Name,
                    IconImagePath = a.AssetResource.IconImage,
                    LatestVersion = a.LatestVersion,
                    Name = a.Name,

                    CreatedAt = a.CreatedAt,
                    ModifiedAt = a.ModifiedAt,
                    ReleasedAt = a.ReleasedAt
                })
                .ToListAsync();

            // return result
            return assets;
        }
    }
}
