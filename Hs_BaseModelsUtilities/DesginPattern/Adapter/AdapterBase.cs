namespace Hs_BaseModelsUtilities.DesginPattern.Adapter
{
    
        public class AdapterBase : ITarget
        {
            private readonly object _adaptee;
            public AdapterBase(object adaptee) => _adaptee = adaptee;
            public virtual void Request() { }
        }
    

}
