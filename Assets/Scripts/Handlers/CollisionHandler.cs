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
                        if (Player.Instance.LastDirectionalInput == Direction.Up)
                        {
                            Player.Instance.CanMoveUp = false;
                            Player.Instance.CanMoveLeft = true;
                            Player.Instance.CanMoveRight = true;
                            Player.Instance.CanMoveDown = true;
                        }
                        else if (Player.Instance.LastDirectionalInput == Direction.Left)
                        {
                            Player.Instance.CanMoveLeft = false;
                            Player.Instance.CanMoveUp = true;
                            Player.Instance.CanMoveRight = true;
                            Player.Instance.CanMoveDown = true;
                        }
                        else if (Player.Instance.LastDirectionalInput == Direction.Right)
                        {
                            Player.Instance.CanMoveRight = false;
                            Player.Instance.CanMoveUp = true;
                            Player.Instance.CanMoveLeft = true;
                            Player.Instance.CanMoveDown = true;
                        }
                        else if (Player.Instance.LastDirectionalInput == Direction.Down)
                        {
                            Player.Instance.CanMoveDown = false;
                            Player.Instance.CanMoveUp = true;
                            Player.Instance.CanMoveRight = true;
                            Player.Instance.CanMoveLeft = true;
                        }
                    }
                }
            }
            else
            {
                Player.Instance.CanMoveDown = true;
                Player.Instance.CanMoveUp = true;
                Player.Instance.CanMoveRight = true;
                Player.Instance.CanMoveLeft = true;
            }
        }

        private int CastRay()
        {
            if (Direction.Directions.Contains(Player.Instance.Input))
                return _boxCollider2D.Raycast(Direction.VectorDirections[Player.Instance.Input], _results, RaycastLen);
            return 0;
        }
    }
}