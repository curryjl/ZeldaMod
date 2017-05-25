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
                    if (raycastHit2D.collider != null)
                    {
                        if (raycastHit2D.collider.tag == Constants.DungeonTag)
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
                        
                        TraverseDungeon(raycastHit2D);
                        ClearCollider(raycastHit2D);
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

        private void ClearCollider(RaycastHit2D raycastHit2D)
        {
            raycastHit2D.collider.name = string.Empty;
        }

        private void TraverseDungeon(RaycastHit2D raycastHit2D)
        {
            List<string> entrances = new List<string>(Constants.PositionByWisdomRooms.Keys);

            if (entrances.Contains(raycastHit2D.collider.name))
            {
                DungeonManager.Instance.UpdateCurrentRoom(raycastHit2D.collider.name);
                Player.Instance.transform.position = Constants.PositionByWisdomRooms[raycastHit2D.collider.name];
                GameManager.Instance.MainCamera.transform.position = new Vector3(-20f, 0f, -10f);
            }
        }
    }
}