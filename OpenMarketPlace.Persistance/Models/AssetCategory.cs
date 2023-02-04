using OpenMarketPlace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMarketPlace.Persistance.Models
{
    public class AssetCategory : BNamedEntity<int, ApplicationUser>
    {
        public List<Asset>? Assets { get; set; }
    }
}
