using OpenMarketPlace.Persistance.BaseModels;
using OpenMarketPlace.Persistance.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenMarketPlace.Persistance.Models
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
