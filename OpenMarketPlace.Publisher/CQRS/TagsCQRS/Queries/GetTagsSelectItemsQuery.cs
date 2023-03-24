using MediatR;
using Microsoft.EntityFrameworkCore;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Dtos;

namespace OpenMarketPlace.Publisher.CQRS.TagsCQRS.Queries
{
    public class GetTagsSelectItemsQuery : IRequest<IEnumerable<SelectItemDto<int>>>
    {
    }

    public class GetTagsSelectItemsQueryHandler : IRequestHandler<GetTagsSelectItemsQuery, IEnumerable<SelectItemDto<int>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetTagsSelectItemsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectItemDto<int>>> Handle(GetTagsSelectItemsQuery request, CancellationToken cancellationToken)
        {
            // get data
            var tags = await _dbContext.Tags
                .Select(eV => new SelectItemDto<int>()
                {
                    Id = eV.Id,
                    Name = eV.Name,
                })
                .ToListAsync(cancellationToken);

            // return result
            return tags;
        }
    }
}
