using AutoMapper;
using MediatR;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;

namespace OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands
{
    public class UpdateAssetReleaseDetailsCommand : IRequest<Asset>
    {
        public UpdateAssetReleaseDetailsDto? AssetReleaseDetails { get; set; }
    }

    public class UpdateAssetReleaseDetailsCommandHandler : IRequestHandler<UpdateAssetReleaseDetailsCommand, Asset>
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _dbContext;

        public UpdateAssetReleaseDetailsCommandHandler(IMapper mapper, ApplicationDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<Asset> Handle(UpdateAssetReleaseDetailsCommand request, CancellationToken cancellationToken)
        {
            // map dto to model
            var asset = _mapper.Map<Asset>(request.AssetReleaseDetails);

            // attach to context
            _dbContext.Attach(asset);

            // specify properties to update
            _dbContext.Entry(asset).Property(c => c.EngineCompatibility).IsModified = true;
            _dbContext.Entry(asset).Property(c => c.License).IsModified = true;
            _dbContext.Entry(asset).Property(c => c.ReleaseNotes).IsModified = true;
            _dbContext.Entry(asset).Property(c => c.Version).IsModified = true;

            // add and save record
            await _dbContext.SaveChangesAsync(cancellationToken);

            // return result
            return asset;
        }
    }
}
