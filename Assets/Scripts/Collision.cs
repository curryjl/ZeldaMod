using UnityEngine;

public class Collision : MonoBehaviour
{
    private BoxCollider2D _boxCollider2D;
    private readonly RaycastHit2D[] _results = new RaycastHit2D[10];
    private const float RaycastLen = 0.07f;
    private const float DiagRaycastLen = 0.1f;

    void Awake()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

	void Update ()
    {
        AllowMovementBeforeRaycastCheck();
        var objectsHit = CastRay();
        CheckForCollision(objectsHit);
        RemoveCollision(objectsHit);
    }

    private void AllowMovementBeforeRaycastCheck()
    {
        Player.Instance.MoveScript.CanMoveForward = true;
    }

    private void CheckForCollision(int numOfCollisions)
    {
        if (numOfCollisions < 1) return;
        for (var i = 0; i < numOfCollisions; i++)
        {
            if (_results[i].collider != null && _results[i].collider.tag == "Dungeon")
            {
                Player.Instance.MoveScript.CanMoveForward = false;
            }
        }
    }

    private int CastRay()
    {
        // Casts 3 rays and returns whichever one has more than one result first
        var upResults = _boxCollider2D.Raycast(Vector2.up, _results, RaycastLen);
        var leftResults = _boxCollider2D.Raycast(new Vector2(-1f, 1f), _results, DiagRaycastLen);
        var rightResults = _boxCollider2D.Raycast(new Vector2(1f, 1f), _results, DiagRaycastLen);

        if (rightResults > 0)
            return rightResults;
        else if (leftResults > 0)
            return leftResults;
        else
            return upResults;
    }

    private void RemoveCollision(int numOfCollisions)
    {
        for (var i = 0; i < numOfCollisions; i++)
        {
            _results[i] = new RaycastHit2D();
        }
    }
}
