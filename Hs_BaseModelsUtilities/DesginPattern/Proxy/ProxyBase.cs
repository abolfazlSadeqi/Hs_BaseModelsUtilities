namespace Hs_BaseModelsUtilities.DesginPattern.Proxy
{

    public class ProxyBase : IProxy
    {
        private readonly IProxy _realSubject;
        public ProxyBase(IProxy realSubject) => _realSubject = realSubject;
        public void Request()
        {
            _realSubject.Request();
        }
    }


}
