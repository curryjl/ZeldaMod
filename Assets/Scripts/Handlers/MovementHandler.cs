using System.Collections.Generic;
using Assets.Scripts.Singletons;
using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
    public class MovementHandler : MonoBehaviour
    {
        private const float Min = -0.010f;
        private const float Max = 0.010f;
        private const float Speed = .75f;
        private string _lastDirectionalInputValue;

        void Update()
        {
            Move();
        }

        private void Move()
        {

            float movementSpeed = 0;
            if (Player.Instance.Input == Constants.Left && Player.Instance.MoveableDirections[Constants.Left])
            {
                movementSpeed = Mathf.Clamp(Speed * -1 * Time.deltaTime, Min, Max);
                transform.Translate(movementSpeed, 0f, 0f);
            }
            else if (Player.Instance.Input == Constants.Right && Player.Instance.MoveableDirections[Constants.Right])
            {
                movementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
                transform.Translate(movementSpeed, 0f, 0f);
            }
            else if (Player.Instance.Input == Constants.Up && Player.Instance.MoveableDirections[Constants.Up])
            {
                movementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
                transform.Translate(0f, movementSpeed, 0f);
            }
            else if (Player.Instance.Input == Constants.Down && Player.Instance.MoveableDirections[Constants.Down])
            {
                movementSpeed = Mathf.Clamp(Speed * -1 * Time.deltaTime, Min, Max);
                transform.Translate(0f, movementSpeed, 0f);
            }

            _lastDirectionalInputValue = Player.Instance.Input != "None"
                ? Player.Instance.Input
                : _lastDirectionalInputValue;
        }
    }
}