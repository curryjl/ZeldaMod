using System;
using Assets.Scripts.StateMachine.Interfaces;
using Assets.Scripts.Static;
using NUnit.Framework.Constraints;

namespace Assets.Scripts.StateMachine.States
{
    public class Attack : IHandler
    {
        public void HandleInput(string input, PlayerContext context)
        {
            throw new NotImplementedException();
        }
    }
}