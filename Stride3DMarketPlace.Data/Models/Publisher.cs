using Stride3DMarketPlace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.Models
{
    public class Publisher : BNamedEntity<int>
    {
        public string? ProfilePhoto { get; set; }
    }
}
