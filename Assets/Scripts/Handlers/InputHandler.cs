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
            if (Constants.Directions.Contains(Player.Instance.Input))
                Player.Instance.LastDirectionalInput = Player.Instance.Input;
        }

        private string GetInput()
        {
            if (Input.GetKey(KeyCode.A))
                return Constants.Left;
            if (Input.GetKey(KeyCode.D))
                return Constants.Right;
            if (Input.GetKey(KeyCode.W))
                return Constants.Up;
            if (Input.GetKey(KeyCode.S))
                return Constants.Down;

            if (Input.GetKeyUp(KeyCode.A))
                return Constants.LeftKeyUp;
            if (Input.GetKeyUp(KeyCode.D))
                return Constants.RightKeyUp;
            if (Input.GetKeyUp(KeyCode.W))
                return Constants.UpKeyUp;
            if (Input.GetKeyUp(KeyCode.S))
                return Constants.DownKeyUp;

            if (Input.GetKeyDown(KeyCode.Space))
                return Constants.Attack; 

            return Constants.NoneKey;
        }
    }
}