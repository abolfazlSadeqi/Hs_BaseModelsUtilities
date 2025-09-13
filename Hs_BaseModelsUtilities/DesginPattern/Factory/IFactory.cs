namespace Hs_BaseModelsUtilities.DesginPattern.Factory
{

    public interface IFactory<T>
    {
        T Create(params object[] args);
    }


}
