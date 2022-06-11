using AutoMapper;
using MediatR;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Models;
using Stride3DMarketPlace.Seller.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Seller.CQRS.AssetCQRS
{
    public class CreateAssetCommand : IRequest<Asset>
    {
        public CreateAssetDto Asset { get; set; }
    }

    public class CreateAssetCommandHandler : IRequestHandler<CreateAssetCommand, Asset>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateAssetCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Asset> Handle(CreateAssetCommand request, CancellationToken cancellationToken)
        {
            // map dto to model
            var asset = _mapper.Map<Asset>(request.Asset);

            // add to db
            _dbContext.Add(asset);
            await _dbContext.SaveChangesAsync();

            // return result
            return asset;
        }
    }
}
