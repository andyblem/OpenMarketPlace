using Stride3DMarketPlace.Persistance.BaseModels;
using Stride3DMarketPlace.Persistance.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.Models
{
    public class AssetReleaseState : BNamedEntity<AssetReleaseStateEnums>
    {
        public List<Asset> Assets { get; set; }
    }
}
