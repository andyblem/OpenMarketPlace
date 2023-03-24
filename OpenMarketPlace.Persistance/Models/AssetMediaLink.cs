using OpenMarketPlace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMarketPlace.Persistance.Models
{
    public class AssetMediaLink : BEntity<int, ApplicationUser>
    {
        public string? MediaLink { get; set; }

        public int? AssetId { get; set; }
        [ForeignKey("AssetId")]
        public int? Asset { get; set; }
    }
}
