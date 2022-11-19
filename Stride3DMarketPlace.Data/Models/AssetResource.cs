using Stride3DMarketPlace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.Models
{
    public class AssetResource : BEntity<int, ApplicationUser>
    {
        public string? BannerImage { get; set; }
        public string? IconImage { get; set; }
    }
}
