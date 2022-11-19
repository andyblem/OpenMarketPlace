using Stride3DMarketPlace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.Models
{
    public class AssetTag : BNamedEntity<int, ApplicationUser>
    {
        public int? AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset? Asset { get; set; }

        public int? TagId { get; set; }
        [ForeignKey("TagId")]
        public Tag? Tag { get; set; }
    }
}
