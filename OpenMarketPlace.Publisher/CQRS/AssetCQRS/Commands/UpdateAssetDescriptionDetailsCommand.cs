using AutoMapper;
using MediatR;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;

namespace OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands
{
    public class UpdateAssetDescriptionDetailsCommand : IRequest<Asset>
    {
        public UpdateAssetDescriptionDetailsDto? AssetDescriptionDetails { get; set; }
    }

    public class UpdateAssetDescriptionDetailsCommandHandler : IRequestHandler<UpdateAssetDescriptionDetailsCommand, Asset>
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _dbContext;

        public UpdateAssetDescriptionDetailsCommandHandler(IMapper mapper, ApplicationDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<Asset> Handle(UpdateAssetDescriptionDetailsCommand request, CancellationToken cancellationToken)
        {
            // map dto to model
            var asset = _mapper.Map<Asset>(request.AssetDescriptionDetails);

            // attach to context
            _dbContext.Attach(asset);

            // specify properties to update
            _dbContext.Entry(asset).Property(c => c.AssetCategoryId).IsModified = true;
            _dbContext.Entry(asset).Property(c => c.Description).IsModified = true;
            _dbContext.Entry(asset).Property(c => c.Keywords).IsModified = true;
            _dbContext.Entry(asset).Property(c => c.Name).IsModified = true;

            // add and save record
            await _dbContext.SaveChangesAsync(cancellationToken);

            // return result
            return asset;
        }
    }
}
