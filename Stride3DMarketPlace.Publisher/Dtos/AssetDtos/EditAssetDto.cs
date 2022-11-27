using Stride3dMarketplace.Persistance.Enums;
using System.ComponentModel;

namespace Stride3dMarketplace.Publisher.Dtos.AssetDtos
{
    public class EditAssetDto
    {
        // basic details

        public int Id { get; set; }

        public string? Description { get; set; }

        [DisplayName("Git Repository")]
        public string? GitRepository { get; set; }

        [DisplayName("Keywords")]
        public string? Keywords { get; set; }

        public string? License { get; set; }
        public string? Name { get; set; }

        [DisplayName("Nuget Repository")]
        public string? NugetPackage { get; set; }


        // release details

        [DisplayName("Engine Compatibility")]
        public string? EngineCompatibility { get; set; }

        [DisplayName("Version")]
        public string? LatestVersion { get; set; }

        [DisplayName("Release Notes")]
        public string? ReleaseNotes { get; set; }


        // media input fields

        public string? BannerImage { get; set; }
        public string? IconImage { get; set; }


        // special details
        public AssetStatusEnums? AssetReleaseStateId { get; set; }

        [DisplayName("Asset Type")]
        public AssetTypeEnum? AssetTypeId { get; set; }

        public string? CreatedById { get; set; }
        public int? PublisherId { get; set; }
    }
}
