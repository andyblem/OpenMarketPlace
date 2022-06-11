﻿using Stride3DMarketPlace.Persistance.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stride3DMarketPlace.Persistance.Models
{
    public class AssetRating : BEntity<int>
    {
        public int Rate { get; set; }

        public int? AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset Asset { get; set; }

        public string RatedById { get; set; }
        [ForeignKey("RatedById")]
        public ApplicationUser RatedBy { get; set; }
    }
}
