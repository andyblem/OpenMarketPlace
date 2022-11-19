using Stride3DMarketPlace.Persistance.BaseModels;
using Stride3DMarketPlace.Persistance.Enums;

namespace Stride3DMarketPlace.Persistance.Models
{
    public class AssetDraft : BAsset
    {
        public AssetDraftStateEnums? AssetDraftStateId { get; set; }
        public AssetDraftState? AssetDraftState { get; set; }
    }
}
