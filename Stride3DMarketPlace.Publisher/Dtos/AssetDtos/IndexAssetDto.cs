using Stride3DMarketPlace.Persistance.Enums;
using System.ComponentModel;

namespace Stride3DMarketPlace.Seller.Dtos.AssetDtos
{
    public class IndexAssetDto
    {
        public int Id { get; set; }

        [DisplayName("Avg Rating")]
        public int Rating { get; set; }


        [DisplayName("Type")]
        public string AssetType { get; set; }

        public string IconImagePath { get; set; }

        [DisplayName("Version")]
        public string LatestVersion { get; set; }

        public string Name { get; set; }


        [DisplayName("Created At")]
        public DateTime? CreatedAt { get; set; }


        [DisplayName("Modified At")]
        public DateTime? ModifiedAt { get; set; }


        [DisplayName("Released At")]
        public DateTime? ReleasedAt { get; set; }


        [DisplayName("State")]
        public AssetReleaseStateEnums? AssetReleaseStateId { get; set; }
    }
}
