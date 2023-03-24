using System;

namespace OpenMarketPlace.Persistance.BaseInterfaces
{
    public interface ISoftDelete
    {
        bool? IsDeleted { get; set; }

        string DeletedById { get; set; }

        DateTime? DeletedAt { get; set; }
    }
}
