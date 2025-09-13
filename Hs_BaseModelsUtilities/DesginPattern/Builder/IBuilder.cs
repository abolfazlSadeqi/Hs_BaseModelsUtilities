namespace Hs_BaseModelsUtilities.DesginPattern.Builder
{

    public interface IBuilder<T>
    {
        IBuilder<T> SetProperty(string name, object value);
        T Build();
    }


}
