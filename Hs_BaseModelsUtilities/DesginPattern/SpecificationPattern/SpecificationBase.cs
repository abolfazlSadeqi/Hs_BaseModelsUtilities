namespace Hs_BaseModelsUtilities.DesginPattern.SpecificationPattern
{

    public abstract class SpecificationBase<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T entity);

        public ISpecification<T> And(ISpecification<T> other) => new AndSpecification<T>(this, other);
        public ISpecification<T> Or(ISpecification<T> other) => new OrSpecification<T>(this, other);
        public ISpecification<T> Not() => new NotSpecification<T>(this);
    }


}
