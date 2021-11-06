using UnityEngine;
using Trell.Animation.Core;

namespace Trell.Animation.Triggers 
{
    public class IdleAnimationTrigger : MonoBehaviour, IAnimationTrigger
    {
        private const string Speed = "Speed";

        private const float MinSpeed = 0f;

        public void UseOn(Animator animator)
        {
            animator.SetFloat(Speed, MinSpeed);
        }
    }
}