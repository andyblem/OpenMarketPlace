using MediatR;
using Microsoft.EntityFrameworkCore;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Models;

namespace OpenMarketPlace.Publisher.CQRS.AssetDownloadLinkCQRS.Queries
{
    public class GetAssetDownloadLinkQuery : IRequest<AssetDownloadLink?>
    {
        public int? Id { get; set; }
    }

    public class GetAssetDownloadLinkQueryHandler : IRequestHandler<GetAssetDownloadLinkQuery, AssetDownloadLink?>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAssetDownloadLinkQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AssetDownloadLink?> Handle(GetAssetDownloadLinkQuery request, CancellationToken cancellationToken)
        {
            // get item
            var assetDownloadLink = await _dbContext.AssetDownloadLinks
                .Where(aDL => aDL.Id == request.Id)
                .FirstOrDefaultAsync(cancellationToken);

            // return result
            return assetDownloadLink;
        }
    }
}
