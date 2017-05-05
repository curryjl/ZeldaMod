using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    public Movement MoveScript { get; private set; }
    public UserInput UserInputScript { get; private set; }
    public Collision CollisionsScript { get; private set; }
    public AnimatorComponent PlayerAnimator { get; private set; }
    public string Input { get; set; }

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

        MoveScript = GetComponent<Movement>();
        UserInputScript = GetComponent<UserInput>();
        CollisionsScript = GetComponent<Collision>();
        PlayerAnimator = GetComponent<AnimatorComponent>();
    }
}