using Stride3dMarketplace.Persistance.BaseModels;
using Stride3dMarketplace.Persistance.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stride3dMarketplace.Persistance.Models
{
    public class AssetDraft : BAsset
    {
        public int? AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset? Asset { get; set; }

        public AssetDraftStatusEnums? AssetDraftStatusId { get; set; }
        public AssetDraftStatus? AssetDraftStatus { get; set; }
    }
}
