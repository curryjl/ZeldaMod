using Assets.Scripts.Singletons;
using Assets.Scripts.StateMachine.Interfaces;
using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.StateMachine.States
{
    public class MoveUp : BaseState, IHandler
    {
        public void HandleInput(string input, PlayerContext context)
        {
            base.SetContext(context);

            if (input == Constants.Up)
            {
                MovementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
                Player.Instance.transform.Translate(0f, MovementSpeed, 0f);
            }
            else
                base.UpdateState();
        }
    }
}