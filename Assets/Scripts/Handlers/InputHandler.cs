using Assets.Scripts.Singletons;
using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
    public class InputHandler : MonoBehaviour
    {
        void Update()
        {
            Player.Instance.Input = GetInput();
            if (Direction.Directions.Contains(Player.Instance.Input))
                Player.Instance.LastDirectionalInput = Player.Instance.Input;
        }

        private string GetInput()
        {
            if (Input.GetKey(KeyCode.A))
                return Direction.Left;
            if (Input.GetKey(KeyCode.D))
                return Direction.Right;
            if (Input.GetKey(KeyCode.W))
                return Direction.Up;
            if (Input.GetKey(KeyCode.S))
                return Direction.Down;

            if (Input.GetKeyUp(KeyCode.A))
                return Direction.LeftKeyUp;
            if (Input.GetKeyUp(KeyCode.D))
                return Direction.RightKeyUp;
            if (Input.GetKeyUp(KeyCode.W))
                return Direction.UpKeyUp;
            if (Input.GetKeyUp(KeyCode.S))
                return Direction.DownKeyUp;

            return Direction.NoneKey;
        }
    }
}