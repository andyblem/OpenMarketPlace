using Stride3DMarketPlace.Database.BaseModels;
using Stride3DMarketPlace.Database.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Database.Models
{
    public class Asset : BNamedEntity<int>
    {
        public string Description { get; set; }
        public string EngineCompatibility { get; set; }
        public string GitRepository { get; set; }
        public string LatestVersion { get; set; }
        public string License { get; set; }
        public string NugetPackage { get; set; }

        public DateTime? LastUpdatedAt { get; set; }
        public DateTime? ReleasedAt { get; set; }

        public AssetReleaseStateEnums? AssetReleaseState { get; set; }

        public int? AssetResourceId { get; set; }
        [ForeignKey("AssetResourceId")]
        public AssetResource AssetResource { get; set; }

        public int? AssetTypeId { get; set; }
        [ForeignKey("AssetTypeId")]
        public AssetType AssetType { get; set; }

        public string CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public ApplicationUser CreatedBy { get; set; }

        public ICollection<AssetReview> AssetReviews { get; set; }
    }
}
