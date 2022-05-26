using System;

namespace Stride3DMarketPlace.Database.BaseInterfaces
{
    public interface ITimeStamp
    {
        bool? IsModified { get; set; }

        string CreatedById { get; set; }
        string ModifiedById { get; set; }

        DateTime? CreatedAt { get; set; }
        DateTime? ModifiedAt { get; set; }
    }
}
