using System;
using System.Collections.Generic;
using Assets.Scripts.Managers;
using Assets.Scripts.Singletons;
using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
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

        void Update()
        {
            var collisionCount = CastRay();
            CheckForCollisions(collisionCount);

        }

        private void CheckForCollisions(int collisionCount)
        {
            if (collisionCount > 0)
            {
                foreach (var raycastHit2D in _results)
                {
                    if (raycastHit2D.collider != null && raycastHit2D.collider.tag == "Dungeon")
                    {
                        // Needed to resolve out of sync issues: http://answers.unity3d.com/questions/409835/out-of-sync-error-when-iterating-over-a-dictionary.html
                        var keys = new List<string>(Player.Instance.MoveableDirections.Keys);
                        foreach (var direction in keys)
                        {
                            if (Player.Instance.LastDirectionalInput == direction)
                                Player.Instance.MoveableDirections[direction] = false;
                            else
                                Player.Instance.MoveableDirections[direction] = true;
                        }
                    }
                    else if (raycastHit2D.collider != null && raycastHit2D.collider.name == "WisdomEntrance")
                    {
                        DungeonManager.Instance.UpdateCurrentRoom("WisdomEntrance");
                        Player.Instance.transform.position = new Vector3(-18.95f, -0.02f);
                        GameManager.Instance.MainCamera.transform.position = new Vector3(-20f, 0f, -10f);
                    }
                }
            }
            else
            {
                var keys = new List<string>(Player.Instance.MoveableDirections.Keys);
                foreach (var moveableDirectionsKey in keys)
                    Player.Instance.MoveableDirections[moveableDirectionsKey] = true;
            }
        }

        private int CastRay()
        {
            if (Constants.Directions.Contains(Player.Instance.Input))
                return _boxCollider2D.Raycast(Constants.VectorByDirection[Player.Instance.Input], _results, RaycastLen);
            return 0;
        }
    }
}