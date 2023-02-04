using OpenMarketPlace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMarketPlace.Persistance.Models
{
    public class EngineVersion : BEntity<int, ApplicationUser>
    {
        public string? Version { get; set; }
    }
}
