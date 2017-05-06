using Assets.Scripts.Interfaces;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    void Update()
    {
        Player.Instance.Input = GetInput();
    }

    private string GetInput()
    {
        if (Input.GetKey(KeyCode.A))
            return Direction.LeftKeyDown;
        if (Input.GetKey(KeyCode.D))
            return Direction.RightKeyDown;
        if (Input.GetKey(KeyCode.W))
            return Direction.UpKeyDown;
        if (Input.GetKey(KeyCode.S))
            return Direction.DownKeyDown;

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
