using AutoMapper;
using MediatR;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Enums;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands;
using OpenMarketPlace.Publisher.Dtos.AssetDownLoadLinkDtos;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;

namespace OpenMarketPlace.Publisher.CQRS.AssetDownloadLinkCQRS
{
    public class CreateAssetDownloadLinkCommand : IRequest<AssetDownloadLink>
    {
        public CreateAssetDownloadLinkDto? AssetDownloadLink { get; set; }
    }

    public class CreateAssetDownloadLinkCommandHandler : IRequestHandler<CreateAssetDownloadLinkCommand, AssetDownloadLink>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateAssetDownloadLinkCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<AssetDownloadLink> Handle(CreateAssetDownloadLinkCommand request, CancellationToken cancellationToken)
        {
            // map dto to model
            var assetDownloadLink = _mapper.Map<AssetDownloadLink>(request.AssetDownloadLink);

            // add extra data
            assetDownloadLink.IsActive = true;

            // add to db
            _dbContext.Add(assetDownloadLink);
            await _dbContext.SaveChangesAsync();

            // return result
            return assetDownloadLink;
        }
    }
}
