using Stride3DMarketPlace.Database.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Database.Models
{
    public class AssetResource : BEntity<int>
    {
        public string BannerImage { get; set; }
        public string IconImage { get; set; }
    }
}
