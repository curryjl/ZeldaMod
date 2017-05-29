using Assets.Scripts.Singletons;
using Assets.Scripts.StateMachine.Interfaces;
using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.StateMachine.States
{
    public class Move : IHandler
    {
        private Vector3 _vector;

        private const float Min = -0.010f;
        private const float Max = 0.010f;
        private const float Speed = .75f;

        public void HandleInput(string input, PlayerContext context)
        {
            if (CanMove(input))
            {
                var movementSpeed = GetMovementSpeed(input);
                SetMovementVector(input, movementSpeed);
                UpdatePlayer(_vector);
            }
        }

        private bool CanMove(string input)
        {
            if (Constants.Directions.Contains(input))
            {
                return Player.Instance.MoveableDirections[input];
            }
            return false;
        }

        private void SetMovementVector(string input, float movementSpeed)
        {
            if (input == Constants.Left || input == Constants.Right)
                _vector = new Vector3(movementSpeed, 0f, 0f);
            if (input == Constants.Up || input == Constants.Down)
                _vector = new Vector3(0f, movementSpeed, 0f);
        }

        private float GetMovementSpeed(string input)
        {
            if (input == "Left" || input == "Down")
                return Mathf.Clamp(Speed * -1 * Time.deltaTime, Min, Max);
            return Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
        }

        private void UpdatePlayer(Vector3 vector)
        {
            Player.Instance.transform.Translate(vector);
        }
    }
}
