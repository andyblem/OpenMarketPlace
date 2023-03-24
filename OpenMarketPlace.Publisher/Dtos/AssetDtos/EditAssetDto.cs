using OpenMarketPlace.Persistance.Enums;
using OpenMarketPlace.Persistance.Models;
using System.ComponentModel;

namespace OpenMarketPlace.Publisher.Dtos.AssetDtos
{
    public class EditAssetDto
    {
        // basic details

        [DisplayName("Category")]
        public int? AssetCategoryId { get; set; }
        public int Id { get; set; }

        public string? Description { get; set; }
        public string? Name { get; set; }

        public List<string?> Keywords { get; set; }


        // release details

        [DisplayName("Engine Compatibility")]
        public List<string?> EngineCompatibility { get; set; }
        public string? License { get; set; }

        [DisplayName("Version")]
        public string? Version { get; set; }

        [DisplayName("Release Notes")]
        public string? ReleaseNotes { get; set; }


        // media input fields

        public string? BannerImage { get; set; }
        public string? IconImage { get; set; }


        // download details
        public ICollection<AssetDownloadLink> DownloadLinks { get; set; }


        // special details
        public AssetStatusEnums? AssetStatusId { get; set; }


        public string? CreatedById { get; set; }
        public int? PublisherId { get; set; }
    }
}
