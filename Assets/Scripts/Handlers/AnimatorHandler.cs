using System.Collections.Generic;
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
            SetMovementAnimatorParamaters();
            SetAttackAnimatorParameters();
        }

        private void SetAttackAnimatorParameters()
        {
            if (Player.Instance.Input == Constants.Attack)
            {
                var keys = new List<string>(Constants.AttackDirections.Keys);
                foreach (var key in keys)
                {
                    if (key == Player.Instance.LastDirectionalInput)
                        Animator.SetTrigger(Constants.AttackDirections[key]);
                }
            }
        }

        private void SetMovementAnimatorParamaters()
        {
            foreach (var key in Constants.Directions)
            {
                Animator.SetBool(key, Player.Instance.Input == key);
            }
        }
    }
}