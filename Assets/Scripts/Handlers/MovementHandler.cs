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

            if (Player.Instance.Input == Direction.Left && Player.Instance.CanMoveLeft)
            {
                movementSpeed = Mathf.Clamp(Speed * -1 * Time.deltaTime, Min, Max);
                transform.Translate(movementSpeed, 0f, 0f);
            }
            else if (Player.Instance.Input == Direction.Right && Player.Instance.CanMoveRight)
            {
                movementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
                transform.Translate(movementSpeed, 0f, 0f);
            }
            else if (Player.Instance.Input == Direction.Up && Player.Instance.CanMoveUp)
            {
                movementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
                transform.Translate(0f, movementSpeed, 0f);
            }
            else if (Player.Instance.Input == Direction.Down && Player.Instance.CanMoveDown)
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