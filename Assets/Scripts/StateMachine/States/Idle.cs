using Assets.Scripts.StateMachine.Interfaces;
using Assets.Scripts.Static;

namespace Assets.Scripts.StateMachine.States
{
    public class Idle : IHandler
    {
        public void HandleInput(string input, PlayerContext context)
        {
            if (Constants.Directions.Contains(input))
                context.SetState(new Move());
            else if (Constants.Attack == input)
                context.SetState(new Attack());
        }
    }
}