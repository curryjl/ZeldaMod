using Assets.Scripts.Interfaces;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    public string Input = Direction.NoneKey;
    public bool CanMoveUp = true;
    public bool CanMoveDown = true;
    public bool CanMoveRight = true;
    public bool CanMoveLeft = true;

    private int _health = 3;

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