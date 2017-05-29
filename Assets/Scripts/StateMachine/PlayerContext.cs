using Assets.Scripts.Singletons;
using Assets.Scripts.StateMachine.Interfaces;
using Assets.Scripts.StateMachine.States;
using UnityEngine;

namespace Assets.Scripts.StateMachine
{
    public class PlayerContext : MonoBehaviour
    {
        private IHandler _currentState;


        void Awake()
        {
            SetState(new Idle());
        }

        public void SetState(IHandler handler)
        {
            _currentState = handler;
        }

        void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            if (Player.Instance.Input != null)
                _currentState.HandleInput(Player.Instance.Input, this);
        }
    }
}