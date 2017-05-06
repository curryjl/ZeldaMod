using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private const float DiagRaycastLen = 0.1f;
    private const float RaycastLen = 0.07f;
    private BoxCollider2D _boxCollider2D;
    private readonly RaycastHit2D[] _results = new RaycastHit2D[10];

    void Awake()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

	void Update ()
    {
        SetMoveableDirections();
        AllowMovementBeforeRaycastCheck();
        var objectsHit = CastRay();
        CheckForCollision(objectsHit);
        RemoveCollision(objectsHit);
    }

    private void AllowMovementBeforeRaycastCheck()
    {
    }

    private void CheckForCollision(int numOfCollisions)
    {
        if (numOfCollisions < 1) return;
        for (var i = 0; i < numOfCollisions; i++)
        {
            if (_results[i].collider != null && _results[i].collider.tag == "Dungeon")
            {
                if (Player.Instance.Input == "Up")
                    Player.Instance.CanMoveUp = false;
                else if (Player.Instance.Input == "Right")
                    Player.Instance.CanMoveRight = false;
                else if (Player.Instance.Input == "Down")
                    Player.Instance.CanMoveDown = false;
                else if (Player.Instance.Input == "Left")
                    Player.Instance.CanMoveLeft = false;
            }
        }
    }

    private int CastRay()
    {
        //var upResults = _boxCollider2D.Raycast(Vector2.up, _results, RaycastLen);
        //var leftResults = _boxCollider2D.Raycast(Vector2.left, _results, RaycastLen);
        //var rightResults = _boxCollider2D.Raycast(Vector2.right, _results, RaycastLen);
        //var downResults = _boxCollider2D.Raycast(Vector2.down, _results, RaycastLen);

        //if (rightResults > 0)
        //    return rightResults;
        //else if (leftResults > 0)
        //    return leftResults;
        //else
        //    return upResults;

        return 0;
    }

    private void RemoveCollision(int numOfCollisions)
    {
        for (var i = 0; i < numOfCollisions; i++)
        {
            _results[i] = new RaycastHit2D();
        }
    }

    private void SetMoveableDirections()
    {
        //if (Player.Instance.Input == "None")
        //{
        //    Player.Instance.CanMoveRight = true;
        //    Player.Instance.CanMoveUp = true;
        //    Player.Instance.CanMoveDown = true;
        //    Player.Instance.CanMoveLeft = true;
        //}
        //if (Player.Instance.Input == "Left" || Player.Instance.Input == "LeftIsUp")
        //{
        //    Player.Instance.CanMoveRight = true;
        //    Player.Instance.CanMoveUp = true;
        //    Player.Instance.CanMoveDown = true;
        //}
        //else if (Player.Instance.Input == "Up" || Player.Instance.Input == "UpIsUp")
        //{
        //    Player.Instance.CanMoveRight = true;
        //    Player.Instance.CanMoveLeft = true;
        //    Player.Instance.CanMoveDown = true;
        //}
        //else if (Player.Instance.Input == "Right" || Player.Instance.Input == "RightIsUp")
        //{
        //    Player.Instance.CanMoveUp = true;
        //    Player.Instance.CanMoveLeft = true;
        //    Player.Instance.CanMoveDown = true;
        //}
        //else if (Player.Instance.Input == "Down" || Player.Instance.Input == "DownIsUp")
        //{
        //    Player.Instance.CanMoveRight = true;
        //    Player.Instance.CanMoveLeft = true;
        //    Player.Instance.CanMoveUp = true;
        //}
    }
}
