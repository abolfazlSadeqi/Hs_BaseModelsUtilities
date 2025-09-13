namespace Hs_BaseModelsUtilities.DesginPattern.Visitor
{
    public interface IElement
    {
        void Accept<T>(IVisitor<T> visitor);
    }


}
