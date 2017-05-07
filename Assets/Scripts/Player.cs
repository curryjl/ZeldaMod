using System.Collections.Generic;
using Assets.Scripts.Interfaces;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    public string Input = Direction.NoneKey;
    public string LastDirectionalInput = Direction.NoneKey;
    public bool CanMoveRight = true;
    public bool CanMoveLeft = true;
    public bool CanMoveUp = true;
    public bool CanMoveDown = true;
    public int Health = 3;

    void Awake ()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
}