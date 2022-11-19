using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.Dtos
{
    public class SelectItemDto<T>
    {
        public T? Id { get; set; }
        public string? Name { get; set; }
    }
}
