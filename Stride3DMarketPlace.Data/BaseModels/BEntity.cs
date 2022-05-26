using Stride3DMarketPlace.Database;
using Stride3DMarketPlace.Database.Models;
using Stride3DMarketPlace.Database.BaseInterfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stride3DMarketPlace.Database.BaseModels
{
    public class BEntity<T> : ITimeStamp, ISoftDelete
    {
        public bool? IsDeleted { get; set; }
        public bool? IsModified { get; set; }


        public T Id { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public string CreatedById { get; set; }
        public string DeletedById { get; set; }
        public string ModifiedById { get; set; }
    }
}
