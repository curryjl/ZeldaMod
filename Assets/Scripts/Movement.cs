using UnityEngine;

public class Movement : MonoBehaviour
{
    private const float Min = -0.010f;
    private const float Max = 0.010f;
    private const float Speed = .75f;
    private string _lastDirectionalInputValue = "Up";

    public string DirectionalInput = string.Empty;
    public bool CanMoveForward = true;

    public bool canMoveDown = true;
    public bool canMoveRight = true;
    public bool canMoveLeft = true;

	void Update ()
	{
	    float movementSpeed = 0;

	    if (DirectionalInput == "Left" && canMoveLeft)
	    {
	        movementSpeed = Mathf.Clamp(Speed * -1 * Time.deltaTime, Min, Max);
	        transform.Translate(movementSpeed, 0f, 0f);
        }
        else if (DirectionalInput == "Right" && canMoveRight)
	    {
	        movementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
            transform.Translate(movementSpeed, 0f, 0f);
        }
        else if (DirectionalInput == "Up" && CanMoveForward)
	    {
	        movementSpeed = Mathf.Clamp(Speed * 1 * Time.deltaTime, Min, Max);
	        transform.Translate(0f, movementSpeed, 0f);
        }
        else if (DirectionalInput == "Down" && canMoveDown)
	    {
	        movementSpeed = Mathf.Clamp(Speed * -1 * Time.deltaTime, Min, Max);
            transform.Translate(0f, movementSpeed, 0f);
        }

        // Should never hold the value None
	    _lastDirectionalInputValue = DirectionalInput != "None" ? DirectionalInput : _lastDirectionalInputValue;
    }
}
