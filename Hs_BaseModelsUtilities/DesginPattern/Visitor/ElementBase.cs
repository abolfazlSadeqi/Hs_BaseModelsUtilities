using System.Linq;
using System.Text;

namespace Hs_BaseModelsUtilities.DesginPattern.Visitor
{

    public class ElementBase<T> : IElement
    {
        private readonly T _value;
        public ElementBase(T value) => _value = value;
        public void Accept<TVisitor>(IVisitor<TVisitor> visitor)
        {
            if (_value is TVisitor v)
                visitor.Visit(v);
        }
    }


}
