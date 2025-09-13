namespace Hs_BaseModelsUtilities.DesginPattern.SpecificationPattern
{

    public class AndSpecification<T> : SpecificationBase<T>
    {
        private readonly ISpecification<T> _left;
        private readonly ISpecification<T> _right;
        public AndSpecification(ISpecification<T> left, ISpecification<T> right) { _left = left; _right = right; }
        public override bool IsSatisfiedBy(T entity) => _left.IsSatisfiedBy(entity) && _right.IsSatisfiedBy(entity);
    }


}
