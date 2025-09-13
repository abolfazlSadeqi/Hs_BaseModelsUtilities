namespace Hs_BaseModelsUtilities.DesginPattern.Command
{

    public interface ICommand
    {
        void Execute();
        Task ExecuteAsync();
    }


}
