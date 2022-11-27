using System;

namespace Stride3dMarketplace.Persistance.BaseInterfaces
{
    public interface ISoftDelete
    {
        bool? IsDeleted { get; set; }

        string DeletedById { get; set; }

        DateTime? DeletedAt { get; set; }
    }
}
