using MediatR;
using Microsoft.EntityFrameworkCore;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Dtos;
using OpenMarketPlace.Publisher.CQRS.AssetCategoryCQRS.Queries;

namespace OpenMarketPlace.Publisher.CQRS.EngineVersionCQRS.Queries
{
    public class GetEngineVersionSelectItemsQuery : IRequest<IEnumerable<SelectItemDto<int>>>
    {
    }

    public class GetEngineVersionSelectItemsQueryHandler : IRequestHandler<GetEngineVersionSelectItemsQuery, IEnumerable<SelectItemDto<int>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetEngineVersionSelectItemsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectItemDto<int>>> Handle(GetEngineVersionSelectItemsQuery request, CancellationToken cancellationToken)
        {
            // get data
            var engineVersions = await _dbContext.EngineVersions
                .Select(eV => new SelectItemDto<int>()
                {
                    Id = eV.Id,
                    Name = eV.Version,
                })
                .ToListAsync(cancellationToken);

            // return result
            return engineVersions;
        }
    }
}
