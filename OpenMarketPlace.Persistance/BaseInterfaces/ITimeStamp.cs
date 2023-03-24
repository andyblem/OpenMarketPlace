using System;

namespace OpenMarketPlace.Persistance.BaseInterfaces
{
    public interface ITimeStamp
    {
        bool? IsModified { get; set; }

        string? CreatedById { get; set; }
        string? ModifiedById { get; set; }

        DateTime? CreatedAt { get; set; }
        DateTime? ModifiedAt { get; set; }
    }
}
