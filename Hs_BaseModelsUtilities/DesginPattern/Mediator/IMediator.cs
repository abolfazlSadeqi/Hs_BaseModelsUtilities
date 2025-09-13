namespace Hs_BaseModelsUtilities.DesginPattern.Mediator
{
    public interface IMediator
    {
        void Register<TMessage>(Action<TMessage> handler);
        void Send<TMessage>(TMessage message);
    }


}
