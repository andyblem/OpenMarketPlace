using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Seller.Data;

namespace Stride3DMarketPlace.Seller.CQRS.PublisherCQRS.Queries
{
    public class GetUserPublisherIdQuery : IRequest<int?>
    {
        public string? UserId { get; set; }
    }

    public class GetUserPublisherIdQueryHandler : IRequestHandler<GetUserPublisherIdQuery, int?>
    {
        private readonly SellerDbContext _context;

        public GetUserPublisherIdQueryHandler(SellerDbContext context)
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
