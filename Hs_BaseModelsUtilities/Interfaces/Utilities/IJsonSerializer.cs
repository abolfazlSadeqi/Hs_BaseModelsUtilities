
using System;

namespace Hs_BaseModelsUtilities.Interfaces.Utilities
{
    public interface IJsonSerializer
    {
        string Serialize(object obj);
        T Deserialize<T>(string json);
        object Deserialize(string json, Type type);
    }

}
