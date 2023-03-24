using AutoMapper;
using FluentValidation;
using MediatR;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Persistance.Enums;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;

namespace OpenMarketPlace.Publisher.CQRS.AssetCQRS.Commands
{
    public class CreateAssetCommand : IRequest<Asset>
    {
        public CreateAssetDto? Asset { get; set; }
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

            // add extra data
            asset.AssetStatusId = AssetStatusEnums.Draft;
            //asset.AssetDraft = new AssetDraft()
            //{
            //    AssetDraftStatusId = AssetDraftStatusEnums.Draft,
            //    Version = "1.0.0"
            //};

            // add to db
            _dbContext.Add(asset);
            await _dbContext.SaveChangesAsync();

            // return result
            return asset;
        }
    }
}
