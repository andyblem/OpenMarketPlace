using Stride3dMarketplace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3dMarketplace.Persistance.Models
{
    public class Publisher : BNamedEntity<int, ApplicationUser>
    {
        public string? ProfilePhoto { get; set; }

        public ICollection<ApplicationUser>? ApplicationUsers { get; set; }
    }
}
