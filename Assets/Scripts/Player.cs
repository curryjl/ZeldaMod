using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    public Movement MoveScript { get; private set; }
    public UserInput UserInputScript { get; private set; }
    public Collision CollisionsScript { get; private set; }
    public int Health { get; private set; }

    void Awake ()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        MoveScript = GetComponent<Movement>();
        UserInputScript = GetComponent<UserInput>();
        CollisionsScript = GetComponent<Collision>();
        Health = 3;
    }
}