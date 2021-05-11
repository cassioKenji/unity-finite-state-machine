namespace FStateMachine
{
    public interface IPlayerState
    {
        public abstract void OnStateTick();
        public abstract void OnStateEnter();
        public abstract void OnStateExit();
    }
}
