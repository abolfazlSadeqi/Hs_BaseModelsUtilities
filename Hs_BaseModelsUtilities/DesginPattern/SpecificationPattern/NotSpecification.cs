namespace Hs_BaseModelsUtilities.DesginPattern.SpecificationPattern
{

    public class NotSpecification<T> : SpecificationBase<T>
    {
        private readonly ISpecification<T> _spec;
        public NotSpecification(ISpecification<T> spec) => _spec = spec;
        public override bool IsSatisfiedBy(T entity) => !_spec.IsSatisfiedBy(entity);
    }

}
