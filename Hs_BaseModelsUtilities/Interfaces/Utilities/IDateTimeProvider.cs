
using System;

namespace Hs_BaseModelsUtilities.Interfaces.Utilities
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
        long UnixTimeSeconds { get; }
    }


}
