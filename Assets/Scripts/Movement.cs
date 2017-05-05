using UnityEngine;

public class Movement : MonoBehaviour
{
    private const float Min = -0.010f;
    private const float Max = 0.010f;
    private const float Speed = .75f;
    private string _lastDirectionalInputValue = "Up";

    public bool CanMoveForward = true;

    public bool canMoveDown = true;
    public bool canMoveRight = true;
    public bool canMoveLeft = true;

	void Update ()
	{
	    Move();
	}

    private void Move()
    {
        float movementSpeed = 0;

        if (Player.Instance.Input == "Left" && canMoveLeft)
        {
            movementSpeed = Mathf.Clamp(Speed * -1 * Time.deltaTime, Min, Max);
            transform.Translate(movementSpeed, 0f, 0f);
        }
        else if (Player.Instance.Input == "Right" && canMoveRight)
        {
            movementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
            transform.Translate(movementSpeed, 0f, 0f);
        }
        else if (Player.Instance.Input == "Up" && CanMoveForward)
        {
            movementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
            transform.Translate(0f, movementSpeed, 0f);
        }
        else if (Player.Instance.Input == "Down" && canMoveDown)
        {
            movementSpeed = Mathf.Clamp(Speed * -1 * Time.deltaTime, Min, Max);
            transform.Translate(0f, movementSpeed, 0f);
        }

        // Should never hold the value None
        _lastDirectionalInputValue = Player.Instance.Input != "None" ? Player.Instance.Input : _lastDirectionalInputValue;
    }
}
