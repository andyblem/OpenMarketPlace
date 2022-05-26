using System;

namespace Stride3DMarketPlace.Database.BaseInterfaces
{
    public interface ISoftDelete
    {
        bool? IsDeleted { get; set; }

        string DeletedById { get; set; }

        DateTime? DeletedAt { get; set; }
    }
}
