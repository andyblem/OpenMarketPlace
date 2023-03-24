using MediatR;
using Microsoft.EntityFrameworkCore;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Enums;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;

namespace OpenMarketPlace.Publisher.CQRS.AssetCQRS.Queries
{
    public class GetIndexAssetsQuery : IRequest<IEnumerable<IndexAssetDto>>
    {
        public int? PublisherId { get; set; }

        public AssetStatusEnums? AssetReleaseStateId { get; set; }
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
            var getAssetsQuery = _dbContext.Assets
                .Where(a => a.PublisherId == request.PublisherId)
                .AsQueryable();

            // add conditions
            if (request.AssetReleaseStateId != null)
            {
                getAssetsQuery = getAssetsQuery.Where(a => a.AssetStatusId == request.AssetReleaseStateId);
            }

            // get data
            var assets = await getAssetsQuery
                .Select(a => new IndexAssetDto()
                {
                    Id = a.Id,
                    Rating = a.Rating,

                    AssetCategory = a.AssetCategory.Name,
                    AssetStatus = a.AssetStatusId,
                    IconImagePath = a.IconImage,
                    Version = a.Version != null ? a.Version : "1.0.0",
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
