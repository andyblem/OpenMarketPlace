using OpenMarketPlace.Persistance;
using OpenMarketPlace.Persistance.Models;
using OpenMarketPlace.Persistance.BaseInterfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenMarketPlace.Persistance.BaseModels
{
    public class BEntity<T1, T2> : ITimeStamp, ISoftDelete
    {
        public bool? IsDeleted { get; set; }
        public bool? IsModified { get; set; }

        public T1? Id { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }


        public string? CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public T2? CreatedBy { get; set; }

        public string? DeletedById { get; set; }
        [ForeignKey("DeletedById")]
        public T2? DeletedBy { get; set; }

        public string? ModifiedById { get; set; }
        [ForeignKey("ModifiedById")]
        public T2? ModifiedBy { get; set; }
    }
}
