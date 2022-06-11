using Stride3DMarketPlace.Persistance;
using Stride3DMarketPlace.Persistance.Models;
using Stride3DMarketPlace.Persistance.BaseInterfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stride3DMarketPlace.Persistance.BaseModels
{
    public class BEntity<T> : ITimeStamp, ISoftDelete
    {
        public bool? IsDeleted { get; set; }
        public bool? IsModified { get; set; }


        public T Id { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public string? CreatedById { get; set; }
        public string? DeletedById { get; set; }
        public string? ModifiedById { get; set; }
    }
}
