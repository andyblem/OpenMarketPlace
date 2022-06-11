using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Store.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Store.CQRS.AssetsCQRS
{
    public class GetTemplatesAssetsQuery : IRequest<IEnumerable<IndexAssetDto>>
    {
        public int Amount { get; set; }
    }

    public class GetTemplatesAssetsQueryHandler : IRequestHandler<GetTemplatesAssetsQuery, IEnumerable<IndexAssetDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetTemplatesAssetsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexAssetDto>> Handle(GetTemplatesAssetsQuery request, CancellationToken cancellationToken)
        {
            // get data
            var templatesAssets = await _dbContext.Assets
                .Where(a => a.AssetReleaseStateId == AssetReleaseStateEnums.Released 
                    && a.AssetTypeId == AssetTypeEnum.TwoD)
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
            return templatesAssets;
        }
    }
}
