using Stride3DMarketPlace.Persistance.Enums;

namespace Stride3DMarketPlace.Seller.Dtos.AssetDtos
{
    public class CreateAssetDto
    {
        // basic details
        public string Description { get; set; }
        public string GitRepository { get; set; }
        public string LatestVersion { get; set; }
        public string License { get; set; }
        public string Name { get; set; }
        public string NugetPackage { get; set; }

        // resource details
        public string BannerImage { get; set; }
        public string IconImage { get; set; }


        // special details
        public AssetReleaseStateEnums? AssetReleaseStateId { get; set; }
        public AssetTypeEnum? AssetTypeId { get; set; }

        public string CreatedById { get; set; }
        public int? PublisherId { get; set; }
    }
}
