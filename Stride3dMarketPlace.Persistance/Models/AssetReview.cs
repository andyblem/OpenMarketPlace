using Stride3dMarketplace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3dMarketplace.Persistance.Models
{
    public class AssetReview : BEntity<int, ApplicationUser>
    {
        public int? AssetRating { get; set; }

        public string? Description { get; set; }


        public int? AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset? Asset { get; set; }

        public string? AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual ApplicationUser? Author { get; set; }
    }
}
