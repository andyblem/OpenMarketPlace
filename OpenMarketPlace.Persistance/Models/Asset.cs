using OpenMarketPlace.Persistance.BaseModels;
using OpenMarketPlace.Persistance.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMarketPlace.Persistance.Models
{
    public class Asset : BAsset
    {
        public AssetStatusEnums? AssetStatusId { get; set; }
        public AssetStatus? AssetStatus { get; set; }


        [ForeignKey("AssetCategoryId")]
        public int? AssetCategoryId { get; set; }
        public AssetCategory? AssetCategory { get; set; }

        [ForeignKey("AssetDraftId")]
        public int? AssetDraftId { get; set; }
        public AssetDraft? AssetDraft { get; set; }

        public int? PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher? Publisher { get; set; }


        public ICollection<AssetDownloadLink>? AssetDownloadLinks { get; set; }
        public ICollection<AssetMediaLink>? AssetMediaLinks { get; set; }
        public ICollection<AssetRating>? AssetRatings { get; set; }
        public ICollection<AssetReview>? AssetReviews { get; set; }
        public ICollection<AssetTag>? AssetTags { get; set; }
    }
}
