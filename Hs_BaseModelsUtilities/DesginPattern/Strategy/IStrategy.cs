namespace Hs_BaseModelsUtilities.DesginPattern.Strategy
{
    public interface IStrategy<T>
    {
        T Execute(params object[] args);
    }


}
