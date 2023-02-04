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
    public class AssetDraftStatus : BNamedEntity<AssetDraftStatusEnums, ApplicationUser>
    {
        public int? AssetDraftId { get; set; }
        [ForeignKey("AssetDraftId")]
        public AssetDraft? AssetDraft { get; set; }
    }
}
