using Assets.Scripts.Singletons;
using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
    public class AnimatorHandler : MonoBehaviour
    {
        public Animator Animator { get; private set; }

        void Awake()
        {
            Animator = GetComponent<Animator>();
        }

        void Update()
        {
            SetAnimatorParamaters();
        }

        private void SetAnimatorParamaters()
        {
            foreach (var key in Direction.Directions)
            {
                Animator.SetBool(key, Player.Instance.Input == key);
            }
        }
    }
}