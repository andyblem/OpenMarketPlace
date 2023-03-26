using AutoMapper;
using MediatR;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.Dtos.AssetDownLoadLinkDtos;

namespace OpenMarketPlace.Publisher.CQRS.AssetDownloadLinkCQRS.Commands
{
    public class UpdateAssetDownloadLinkCommand : IRequest<AssetDownloadLink>
    {
        public UpdateAssetDownloadLinkDto? UpdateAssetDownloadLinkDto { get; set; }
    }

    public class UpdateAssetDownloadLinkCommandHandler : IRequestHandler<UpdateAssetDownloadLinkCommand, AssetDownloadLink>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public UpdateAssetDownloadLinkCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<AssetDownloadLink> Handle(UpdateAssetDownloadLinkCommand request, CancellationToken cancellationToken)
        {
            // map dto to model
            var assetDownloadLink = _mapper.Map<AssetDownloadLink>(request.UpdateAssetDownloadLinkDto);

            // update to db
            _dbContext.Attach(assetDownloadLink);

            // specify properties to update
            _dbContext.Entry(assetDownloadLink).Property(c => c.IsActive).IsModified = true;
            _dbContext.Entry(assetDownloadLink).Property(c => c.IsModified).IsModified = true;
            _dbContext.Entry(assetDownloadLink).Property(c => c.ModifiedById).IsModified = true;
            _dbContext.Entry(assetDownloadLink).Property(c => c.Name).IsModified = true;
            _dbContext.Entry(assetDownloadLink).Property(c => c.Url).IsModified = true;

            // save changes
            await _dbContext.SaveChangesAsync();

            // return result
            return assetDownloadLink;
        }
    }
}
