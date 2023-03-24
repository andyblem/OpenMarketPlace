using OpenMarketPlace.Persistance.Enums;
using OpenMarketPlace.Persistance.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpenMarketPlace.Publisher.Dtos.AssetDtos
{
    public class CreateAssetDto
    {
        [DisplayName("Asset Category")]
        public int? AssetCategoryId { get; set; }

        [DisplayName("Asset Name")]
        public string? Name { get; set; }


        public int? PublisherId { get; set; }
        public string? CreatedById { get; set; }
        public string? Version { get; set; }
    }
}
