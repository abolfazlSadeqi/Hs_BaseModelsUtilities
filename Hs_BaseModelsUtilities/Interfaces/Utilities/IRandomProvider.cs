
using System;

namespace Hs_BaseModelsUtilities.Interfaces.Utilities
{
    public interface IRandomProvider
    {
        int Next(int minValue, int maxValue);
        string GetRandomString(int length);
        Guid GetRandomGuid();
    }



}
