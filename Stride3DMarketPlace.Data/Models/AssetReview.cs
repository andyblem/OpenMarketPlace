using Stride3DMarketPlace.Database.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Database.Models
{
    public class AssetReview : BEntity<int>
    {
        public int? AssetRating { get; set; }

        public string Description { get; set; }


        public int? AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset Asset { get; set; }

        public string AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public ApplicationUser Author { get; set; }
    }
}
