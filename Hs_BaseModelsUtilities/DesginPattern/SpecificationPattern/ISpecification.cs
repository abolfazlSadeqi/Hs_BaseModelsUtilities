namespace Hs_BaseModelsUtilities.DesginPattern.SpecificationPattern
{

    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
        ISpecification<T> And(ISpecification<T> other);
        ISpecification<T> Or(ISpecification<T> other);
        ISpecification<T> Not();
    }


}
