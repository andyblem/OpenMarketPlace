using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3dMarketplace.Persistance.Data;
using Stride3dMarketplace.Persistance.Enums;
using Stride3dMarketplace.Store.Dtos.AssetDtos;

namespace Stride3dMarketplace.Store.CQRS.AssetsCQRS
{
    public class GetTopRatedAssetsQuery : IRequest<IEnumerable<IndexAssetDto>>
    {
        public int Amount { get; set; }
    }

    public class GetTopRatedAssetsQueryHandler : IRequestHandler<GetTopRatedAssetsQuery, IEnumerable<IndexAssetDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetTopRatedAssetsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexAssetDto>> Handle(GetTopRatedAssetsQuery request, CancellationToken cancellationToken)
        {
            // get data
            var TopRatedAssets = await _dbContext.Assets
                .Where(a => a.AssetStatusId == AssetStatusEnums.Published 
                    //&& a.AssetTypeId == AssetTypeEnum.TwoD
                    )
                .Take(request.Amount)
                .Select(a => new IndexAssetDto()
                {
                    Id = a.Id,
                    Reviews = a.AssetReviews.Count,

                    //AssetType = a.AssetType.Name,
                    //IconImagePath = a.AssetResource.IconImage,
                    Name = a.Name
                })
                .ToListAsync();

            // return result
            return TopRatedAssets;
        }
    }
}
