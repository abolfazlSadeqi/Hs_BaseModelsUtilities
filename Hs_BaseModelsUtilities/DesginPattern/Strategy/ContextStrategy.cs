namespace Hs_BaseModelsUtilities.DesginPattern.Strategy
{

    public class ContextStrategy<T>
    {
        private readonly IStrategy<T> _strategy;
        public ContextStrategy(IStrategy<T> strategy) => _strategy = strategy;
        public T Execute(params object[] args) => _strategy.Execute(args);
    }


}
