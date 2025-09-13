namespace Hs_BaseModelsUtilities.DesginPattern.Factory
{
   
    public class FactoryBase<T> : IFactory<T> where T : class
    {
        private readonly Func<object[], T> _creator;
        public FactoryBase(Func<object[], T> creator) => _creator = creator;
        public T Create(params object[] args) => _creator(args);
    }


}
