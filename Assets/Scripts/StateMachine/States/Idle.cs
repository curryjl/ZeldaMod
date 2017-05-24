using System.Linq;
using Assets.Scripts.StateMachine.Interfaces;

namespace Assets.Scripts.StateMachine.States
{
    public class Idle : BaseState, IHandler
    {
        public void HandleInput(string input, PlayerContext context)
        {
            SetContext(context);
            
            if (input == "Left")
                base.Context.SetState(new MoveLeft());
            if (input == "Right")
                base.Context.SetState(new MoveRight());
            if (input == "Up")
                base.Context.SetState(new MoveUp());
            if (input == "Down")
                base.Context.SetState(new MoveDown());
        }
    }
}