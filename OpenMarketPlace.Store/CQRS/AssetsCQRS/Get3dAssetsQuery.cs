using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3dMarketplace.Persistance.Data;
using Stride3dMarketplace.Persistance.Enums;
using Stride3dMarketplace.Store.Dtos.AssetDtos;

namespace Stride3dMarketplace.Store.CQRS.AssetsCQRS
{
    public class Get3dAssetsQuery : IRequest<IEnumerable<IndexAssetDto>>
    {
        public int Amount { get; set; }
    }

    public class Get3dAssetsQueryHandler : IRequestHandler<Get3dAssetsQuery, IEnumerable<IndexAssetDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public Get3dAssetsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<IndexAssetDto>> Handle(Get3dAssetsQuery request, CancellationToken cancellationToken)
        {
            // get data
            var assets3d = await _dbContext.Assets
                .Where(a => //a.AssetTypeId == AssetTypeEnum.ThreeD
                   //&& 
                   a.AssetStatusId == AssetStatusEnums.Published)
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
            return assets3d;
        }
    }
}
