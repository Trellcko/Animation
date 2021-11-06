using UnityEngine;
using Trell.Animation.Core;

namespace Trell.Animation.Triggers
{

    public class AttackAnimationTrigger : IAnimationTrigger
    {
        private const string Attack = "Attack";

        public AttackAnimationTrigger() { }

        public void SetTrigger(Animator animator)
        {
            animator.SetTrigger(Attack);
        }
    }
}