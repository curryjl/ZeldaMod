using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.StateMachine.Interfaces;

namespace Assets.Scripts.StateMachine.States
{
    public class BaseState
    {
        internal const float Min = -0.010f;
        internal const float Max = 0.010f;
        internal const float Speed = .75f;
        internal float MovementSpeed = 0;

        internal PlayerContext Context;

        internal void SetContext(PlayerContext context)
        {
            Context = context;
        }

        internal void UpdateState()
        {
            Context.SetState(new Idle());
        }
    }
}
