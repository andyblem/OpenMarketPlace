using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3dMarketplace.Persistance.Data;
using Stride3dMarketplace.Persistance.Enums;
using Stride3dMarketplace.Store.Dtos.AssetDtos;

namespace Stride3dMarketplace.Store.CQRS.AssetsCQRS
{
    public class GetScriptsAssetsQuery : IRequest<IEnumerable<IndexAssetDto>>
    {
        public int Amount { get; set; }
    }

    public class GetScriptAssetsQueryHandler : IRequestHandler<GetScriptsAssetsQuery, IEnumerable<IndexAssetDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetScriptAssetsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexAssetDto>> Handle(GetScriptsAssetsQuery request, CancellationToken cancellationToken)
        {
            // get data
            var scriptAssets = await _dbContext.Assets
                .Where(a => a.AssetStatusId == AssetStatusEnums.Published
                    //&& a.AssetTypeId == AssetTypeEnum.Scripts
                    )
                .Take(request.Amount)
                .Select(a => new IndexAssetDto()
                {
                    Id = a.Id,
                    Rating = a.Rating,
                    Reviews = a.Reviews,

                    //AssetType = a.AssetType.Name,
                    //IconImagePath = a.AssetResource.IconImage,
                    Name = a.Name,
                    Publisher = a.Publisher.Name
                })
                .ToListAsync();

            // return result
            return scriptAssets;
        }
    }
}
