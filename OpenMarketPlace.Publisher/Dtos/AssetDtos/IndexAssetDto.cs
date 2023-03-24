using OpenMarketPlace.Persistance.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OpenMarketPlace.Publisher.Dtos.AssetDtos
{
    public class IndexAssetDto
    {
        public int Id { get; set; }

        [DisplayName("Avg Rating")]
        public int Rating { get; set; }


        [DisplayName("Type")]
        public string? AssetCategory { get; set; }

        public string? IconImagePath { get; set; }

        [DisplayName("Version")]
        public string? Version { get; set; }

        [DisplayName("Package name")]
        public string? Name { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Created")]
        public DateTime? CreatedAt { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Modified")]
        public DateTime? ModifiedAt { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Released")]
        public DateTime? ReleasedAt { get; set; }


        [DisplayName("Status")]
        public AssetStatusEnums? AssetStatus { get; set; }
    }
}
