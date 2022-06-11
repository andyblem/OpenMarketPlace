using Stride3DMarketPlace.Persistance.BaseModels;
using Stride3DMarketPlace.Persistance.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.Models
{
    public class Asset : BNamedEntity<int>
    {
        public int Rating { get; set; }
        public int Reviews { get; set; }

        public string Description { get; set; }
        public string EngineCompatibility { get; set; }
        public string GitRepository { get; set; }
        public string LatestVersion { get; set; }
        public string License { get; set; }
        public string NugetPackage { get; set; }

        public DateTime? LastUpdatedAt { get; set; }
        public DateTime? ReleasedAt { get; set; }


        public AssetReleaseStateEnums? AssetReleaseStateId { get; set; }
        public AssetReleaseState AssetReleaseState { get; set; }

        public AssetTypeEnum? AssetTypeId { get; set; }
        public AssetType AssetType { get; set; }

        public int? AssetResourceId { get; set; }
        [ForeignKey("AssetResourceId")]
        public AssetResource AssetResource { get; set; }

        public string CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public ApplicationUser CreatedBy { get; set; }

        public int? PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }


        public ICollection<AssetRating> AssetRatings { get; set; }
        public ICollection<AssetReview> AssetReviews { get; set; }
        public ICollection<AssetTag> AssetTags { get; set; }
    }
}
