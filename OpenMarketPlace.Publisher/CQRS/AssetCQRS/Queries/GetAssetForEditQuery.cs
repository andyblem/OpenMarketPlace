using MediatR;
using Microsoft.EntityFrameworkCore;
using OpenMarketPlace.Persistance.Data;
using OpenMarketPlace.Publisher.Dtos.AssetDtos;

namespace OpenMarketPlace.Publisher.CQRS.AssetCQRS.Queries
{
    public class GetAssetForEditQuery : IRequest<EditAssetDto>
    {
        public int? Id { get; set; }
    }

    public class GetAssetForEditQueryHandler : IRequestHandler<GetAssetForEditQuery, EditAssetDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAssetForEditQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<EditAssetDto> Handle(GetAssetForEditQuery request, CancellationToken cancellationToken)
        {
            // get asset
            var asset = _dbContext.Assets
                .Where(a => a.Id == request.Id)
                .Select(a => new EditAssetDto()
                {
                    Id = a.Id,
                    Name = a.Name,

                    Description = a.Description,
                    EngineCompatibility = a.EngineCompatibility,
                    License = a.License,
                    ReleaseNotes = a.ReleaseNotes,
                    Version = a.Version,

                    BannerImage = a.BannerImage,
                    IconImage = a.IconImage,

                    AssetReleaseStateId = a.AssetStatusId,

                    CreatedById = a.CreatedById,
                    PublisherId = a.PublisherId,
                })
                .FirstOrDefaultAsync();

            // return result
            return asset;
        }
    }
}
