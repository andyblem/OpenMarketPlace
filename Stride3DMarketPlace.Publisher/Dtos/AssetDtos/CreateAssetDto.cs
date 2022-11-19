using Stride3DMarketPlace.Persistance.Enums;
using Stride3DMarketPlace.Persistance.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Stride3DMarketPlace.Seller.Dtos.AssetDtos
{
    public class CreateAssetDto
    {
        [DisplayName("Asset Category")]
        public int? AssetCategoryId { get; set; }

        [DisplayName("Asset Name")]
        public string? Name { get; set; }


        public int? PublisherId { get; set; }
        public string? CreatedById { get; set; }
    }
}
