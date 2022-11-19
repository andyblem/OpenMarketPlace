using AutoMapper;
using FluentValidation;
using MediatR;
using Stride3DMarketPlace.Persistance.Data;
using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Persistance.Models;
using Stride3DMarketPlace.Seller.Data;
using Stride3DMarketPlace.Seller.Dtos.AssetDtos;

namespace Stride3DMarketPlace.Seller.CQRS.AssetCQRS.Commands
{
    public class CreateAssetCommand : IRequest<Asset>
    {
        public CreateAssetDto? Asset { get; set; }
    }

    public class CreateAssetCommandHandler : IRequestHandler<CreateAssetCommand, Asset>
    {
        private readonly SellerDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateAssetCommandHandler(SellerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Asset> Handle(CreateAssetCommand request, CancellationToken cancellationToken)
        {
            // map dto to model
            var asset = _mapper.Map<Asset>(request.Asset);

            ////// add extra data
            ////asset.AssetReleaseStateId = AssetReleaseStateEnums.InitDraft;
            ////asset.AssetDraftReleaseStateId = AssetDraftReleaseStateEnums.Available;
            ////asset.AssetDraft = new AssetDraft()
            ////{
            ////    LatestVersion = "1.0.0"
            ////};

            // add to db
            _dbContext.Add(asset);
            await _dbContext.SaveChangesAsync();

            // return result
            return asset;
        }
    }
}
