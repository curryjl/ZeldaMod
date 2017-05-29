using Assets.Scripts.StateMachine.Interfaces;

namespace Assets.Scripts.StateMachine.States
{
    public abstract class BaseState
    {
        internal string Input;
        private PlayerContext _context;

        internal void SetBaseState(PlayerContext context, string input)
        {
            _context = context;
            Input = input;
        }

        internal void UpdateState(IHandler handler)
        {
            _context.SetState(new Idle());
        }
    }
}
