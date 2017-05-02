using UnityEngine;

public class Movement : MonoBehaviour
{
    private readonly float _min = -0.010f;
    private readonly float _max = 0.010f;
    private readonly float _speed = .75f;
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
	        movementSpeed = Mathf.Clamp(_speed * -1 * Time.deltaTime, _min, _max);
	        transform.Translate(movementSpeed, 0f, 0f);
        }
        else if (DirectionalInput == "Right" && canMoveRight)
	    {
	        movementSpeed = Mathf.Clamp(_speed * 1 * Time.deltaTime, _min, _max);
            transform.Translate(movementSpeed, 0f, 0f);
        }
        else if (DirectionalInput == "Up" && CanMoveForward)
	    {
	        movementSpeed = Mathf.Clamp(_speed * 1 * Time.deltaTime, _min, _max);
	        transform.Translate(0f, movementSpeed, 0f);
        }
        else if (DirectionalInput == "Down" && canMoveDown)
	    {
	        movementSpeed = Mathf.Clamp(_speed * -1 * Time.deltaTime, _min, _max);
            transform.Translate(0f, movementSpeed, 0f);
        }

        // Should never hold the value None
	    _lastDirectionalInputValue = DirectionalInput != "None" ? DirectionalInput : _lastDirectionalInputValue;
    }
}
