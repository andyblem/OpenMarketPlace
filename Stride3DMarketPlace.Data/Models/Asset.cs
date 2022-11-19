using Stride3DMarketPlace.Persistance.BaseModels;
using Stride3DMarketPlace.Persistance.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.Models
{
    public class Asset : BAsset
    {
        public AssetDraftReleaseStateEnums? AssetDraftReleaseStateId { get; set; }
        public AssetDraftReleaseState? AssetDraftReleaseState { get; set; }

        public AssetReleaseStateEnums? AssetReleaseStateId { get; set; }
        public AssetReleaseState? AssetReleaseState { get; set; }


        [ForeignKey("AssetCategoryId")]
        public int? AssetCategoryId { get; set; }
        public AssetCategory? AssetCategory { get; set; }

        [ForeignKey("AssetDraftId")]
        public int? AssetDraftId { get; set; }
        public AssetDraft? AssetDraft { get; set; }

        public int? AssetResourceId { get; set; }
        [ForeignKey("AssetResourceId")]
        public AssetResource? AssetResource { get; set; }

        public int? PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher? Publisher { get; set; }


        public ICollection<AssetMediaLink>? AssetMediaLinks { get; set; }
        public ICollection<AssetRating>? AssetRatings { get; set; }
        public ICollection<AssetReview>? AssetReviews { get; set; }
        public ICollection<AssetTag>? AssetTags { get; set; }
    }
}
