using MediatR;
using Microsoft.EntityFrameworkCore;
using OpenMarketPlace.Persistance.Data;

namespace OpenMarketPlace.Publisher.CQRS.PublisherCQRS.Queries
{
    public class GetUserPublisherIdQuery : IRequest<int?>
    {
        public string? UserId { get; set; }
    }

    public class GetUserPublisherIdQueryHandler : IRequestHandler<GetUserPublisherIdQuery, int?>
    {
        private readonly ApplicationDbContext _context;

        public GetUserPublisherIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int?> Handle(GetUserPublisherIdQuery request, CancellationToken cancellationToken)
        {
            // get data
            var publisherId = await _context.Users
                .Where(u => u.Id == request.UserId)
                .Select(u => u.PublisherId)
                .FirstOrDefaultAsync();

            // return result
            return publisherId;
        }
    }
}
