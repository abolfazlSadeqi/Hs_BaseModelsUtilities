namespace Hs_BaseModelsUtilities.DesginPattern.ChainofResponsibility
{

    public abstract class HandlerBase
    {
        protected HandlerBase Next { get; private set; }
        public void SetNext(HandlerBase next) => Next = next;
        public virtual void Handle(object request)
        {
            Next?.Handle(request);
        }
    }



}
