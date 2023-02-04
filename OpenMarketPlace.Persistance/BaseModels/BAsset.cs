using OpenMarketPlace.Persistance.Enums;
using OpenMarketPlace.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMarketPlace.Persistance.BaseModels
{
    public class BAsset : BNamedEntity<int, ApplicationUser>
    {
        public int Rating { get; set; }
        public int Reviews { get; set; }

        public string? BannerImage { get; set; }
        public string? IconImage { get; set; }

        public string? Description { get; set; }
        public string? EngineCompatibility { get; set; }
        public string? License { get; set; }
        public string? ReleaseNotes { get; set; }
        public string? Version { get; set; }

        public DateTime? LastUpdatedAt { get; set; }
        public DateTime? ReleasedAt { get; set; }
    }
}
