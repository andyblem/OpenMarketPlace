using MediatR;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Models;

namespace OpenMarketPlace.Publisher.CQRS.AssetDownloadLinkCQRS.Commands
{
    public class DeleteAssetDownloadLinkCommand : IRequest<bool>
    {
        public AssetDownloadLink AssetDownloadLink { get; set; }
    }

    public class DeleteAssetDownloadLinkCommandHandler : IRequestHandler<DeleteAssetDownloadLinkCommand, bool>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteAssetDownloadLinkCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteAssetDownloadLinkCommand request, CancellationToken cancellationToken)
        {
            // delete link
            _dbContext.Remove(request.AssetDownloadLink);
            await _dbContext.SaveChangesAsync();

            // return result
            return true;
        }
    }
}
