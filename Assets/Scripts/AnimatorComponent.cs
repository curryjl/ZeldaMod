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
        foreach (var key in Direction.KeysDown)
        {
            if (Player.Instance.Input == key)
                Animator.SetBool(key, true);
            else
                Animator.SetBool(key, false);
        }
    }
}
