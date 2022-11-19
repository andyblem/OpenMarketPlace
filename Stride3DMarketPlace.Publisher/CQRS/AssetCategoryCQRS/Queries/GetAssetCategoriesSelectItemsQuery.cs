using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Dtos;
using Stride3DMarketPlace.Seller.Data;

namespace Stride3DMarketPlace.Seller.CQRS.AssetCategoryCQRS.Queries
{
    public class GetAssetCategoriesSelectItemsQuery : IRequest<IEnumerable<SelectItemDto<int>>>
    {
    }

    public class GetAssetCategoriesSelectItemsQueryHandler : IRequestHandler<GetAssetCategoriesSelectItemsQuery, IEnumerable<SelectItemDto<int>>>
    {
        private readonly SellerDbContext _dbContext;

        public GetAssetCategoriesSelectItemsQueryHandler(SellerDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IEnumerable<SelectItemDto<int>>> Handle(GetAssetCategoriesSelectItemsQuery request, CancellationToken cancellationToken)
        {
            // get data
            var assetCategories = await _dbContext.AssetsCategories
                .Select(aC => new SelectItemDto<int>()
                {
                    Id = aC.Id,
                    Name = aC.Name,
                })
                .ToListAsync(cancellationToken);

            // return result
            return assetCategories;
        }
    }
}
