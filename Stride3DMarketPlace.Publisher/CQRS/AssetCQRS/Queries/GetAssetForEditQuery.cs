using MediatR;
using Microsoft.EntityFrameworkCore;
using Stride3dMarketplace.Persistance.Data;
using Stride3dMarketplace.Publisher.Dtos.AssetDtos;

namespace Stride3dMarketplace.Publisher.CQRS.AssetCQRS.Queries
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

                    Description = a.Description,
                    //GitRepository = a.GitRepository,
                    License = a.License,
                    Name = a.Name,
                    //NugetPackage = a.NugetPackage,

                    EngineCompatibility = a.EngineCompatibility,
                    LatestVersion = a.Version,
                    //ReleaseNotes = a.ReleaseNotes,

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
