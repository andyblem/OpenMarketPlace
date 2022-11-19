using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.BaseModels
{
    public class BAsset : BNamedEntity<int, ApplicationUser>
    {
        public int Rating { get; set; }
        public int Reviews { get; set; }

        public string? BannerImage { get; set; }
        public string? IconImage { get; set; }

        public string? Description { get; set; }
        public string? EngineCompatibility { get; set; }
        public string? GitRepository { get; set; }
        public string? LatestVersion { get; set; }
        public string? License { get; set; }
        public string? NugetPackage { get; set; }

        public DateTime? LastUpdatedAt { get; set; }
        public DateTime? ReleasedAt { get; set; }

        public AssetTypeEnum? AssetTypeId { get; set; }
        public AssetType? AssetType { get; set; }
    }
}
