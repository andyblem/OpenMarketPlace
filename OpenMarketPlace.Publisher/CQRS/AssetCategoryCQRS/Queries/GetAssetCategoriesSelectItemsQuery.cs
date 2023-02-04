using MediatR;
using Microsoft.EntityFrameworkCore;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Dtos;

namespace OpenMarketPlace.Publisher.CQRS.AssetCategoryCQRS.Queries
{
    public class GetAssetCategoriesSelectItemsQuery : IRequest<IEnumerable<SelectItemDto<int>>>
    {
    }

    public class GetAssetCategoriesSelectItemsQueryHandler : IRequestHandler<GetAssetCategoriesSelectItemsQuery, IEnumerable<SelectItemDto<int>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAssetCategoriesSelectItemsQueryHandler(ApplicationDbContext context)
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
