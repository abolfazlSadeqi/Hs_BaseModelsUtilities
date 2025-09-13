using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.DesginPattern.Composite
{
    public interface IComponentComposite
    {
        void Operation();
        void Add(IComponentComposite component);
        void Remove(IComponentComposite component);
        IEnumerable<IComponentComposite> GetChildren();
    }


}
