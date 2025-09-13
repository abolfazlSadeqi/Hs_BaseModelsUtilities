using System.Collections.Generic;
namespace Hs_BaseModelsUtilities.DesginPattern.Composite
{
  


    public class CompositeBase : IComponentComposite
    {
        private readonly List<IComponentComposite> _children = new();
        public void Operation()
        {
            foreach (var child in _children)
                child.Operation();
        }
        public void Add(IComponentComposite component) => _children.Add(component);
        public void Remove(IComponentComposite component) => _children.Remove(component);
        public IEnumerable<IComponentComposite> GetChildren() => _children.AsReadOnly();
    }


}
