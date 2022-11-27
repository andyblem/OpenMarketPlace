using Stride3dMarketplace.Persistance.Enums;
using Stride3dMarketplace.Persistance.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Stride3dMarketplace.Publisher.Dtos.AssetDtos
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
