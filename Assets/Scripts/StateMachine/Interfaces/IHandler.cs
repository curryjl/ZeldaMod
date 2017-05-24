using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.StateMachine.Interfaces
{
    public interface IHandler
    {
        void HandleInput(string input, PlayerContext context);
    }
}
