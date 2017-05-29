namespace Assets.Scripts.StateMachine.Interfaces
{
    public interface IHandler
    {
        void HandleInput(string input, PlayerContext context);
    }
}
