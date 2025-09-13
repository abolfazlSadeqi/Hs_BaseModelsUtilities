namespace Hs_BaseModelsUtilities.DesginPattern.Builder
{

    public abstract class BuilderBase<T> : IBuilder<T> where T : new()
    {
        protected readonly T _instance = new T();
        public abstract IBuilder<T> SetProperty(string name, object value);
        public T Build() => _instance;
    }

}
