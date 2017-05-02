using UnityEngine;

public class UserInput : MonoBehaviour
{
	void Update ()
    {
        Player.Instance.MoveScript.DirectionalInput = GetInput();
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
        else
            return "None";
    }
}
