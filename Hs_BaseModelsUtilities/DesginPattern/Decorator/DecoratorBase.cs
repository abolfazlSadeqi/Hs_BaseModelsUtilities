namespace Hs_BaseModelsUtilities.DesginPattern.Decorator
{

    public abstract class DecoratorBase : IComponent
    {
        protected readonly IComponent _component;
        protected DecoratorBase(IComponent component) => _component = component;
        public virtual void Operation() => _component.Operation();
    }


}
