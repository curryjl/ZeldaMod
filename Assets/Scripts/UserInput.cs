using UnityEngine;

public class UserInput : MonoBehaviour
{
	void Update ()
	{
	    Player.Instance.Input = GetInput();
    }

    private string GetInput()
    {
        if (Input.GetKey(KeyCode.A))
            return "Left";
        if (Input.GetKey(KeyCode.D))
            return "Right";
        if (Input.GetKey(KeyCode.W))
            return "Up";
        if (Input.GetKey(KeyCode.S))
            return "Down";

        if (Input.GetKeyUp(KeyCode.A))
            return "LeftIsUp";
        if (Input.GetKeyUp(KeyCode.D))
            return "RightIsUp";
        if (Input.GetKeyUp(KeyCode.W))
            return "UpIsUp";
        if (Input.GetKeyUp(KeyCode.S))
            return "DownIsUp";

        return "None";
    }
}
