using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorComponent : MonoBehaviour
{
    public Animator Animator { get; private set; }

    void Awake ()
    {
        Animator = GetComponent<Animator>();
    }

	void Update ()
	{
        SetAnimatorParamaters();
	}

    private void SetAnimatorParamaters()
    {
        if (Player.Instance.Input == "Left")
            Animator.SetBool("Left", true);
        else if (Player.Instance.Input == "LeftIsUp")
            Animator.SetBool("Left", false);
        else if (Player.Instance.Input == "Right")
            Animator.SetBool("Right", true);
        else if (Player.Instance.Input == "RightIsUp")
            Animator.SetBool("Right", false);
        else if (Player.Instance.Input == "Down")
            Animator.SetBool("Down", true);
        else if (Player.Instance.Input == "DownIsUp")
            Animator.SetBool("Down", false);
        else if (Player.Instance.Input == "Up")
            Animator.SetBool("Up", true);
        else if (Player.Instance.Input == "UpIsUp")
            Animator.SetBool("Up", false);
    }
}
