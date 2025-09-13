namespace Hs_BaseModelsUtilities.DesginPattern.Singleton
{

    /// <summary>
    /// Thread-safe generic singleton base
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SingletonBase<T> where T : class, new()
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => new T());
        public static T Instance => _instance.Value;
    }


}
