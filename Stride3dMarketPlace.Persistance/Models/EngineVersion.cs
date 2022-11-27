using Stride3dMarketplace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3dMarketplace.Persistance.Models
{
    public class EngineVersion : BEntity<int, ApplicationUser>
    {
        public string? Version { get; set; }
    }
}
