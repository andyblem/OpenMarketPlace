using Stride3dMarketplace.Persistance.BaseModels;
using Stride3dMarketplace.Persistance.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3dMarketplace.Persistance.Models
{
    public class AssetStatus : BNamedEntity<AssetStatusEnums, ApplicationUser>
    {
        public int? AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset? Asset { get; set; }
    }
}
