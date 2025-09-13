namespace Hs_BaseModelsUtilities.DesginPattern.State
{
    public class ContextState
    {
        private IState _state;
        public ContextState(IState state) => _state = state;
        public void SetState(IState state) => _state = state;
        public void Request() => _state.Handle();
    }


}
