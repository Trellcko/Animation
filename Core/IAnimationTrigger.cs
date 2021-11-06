using UnityEngine;

namespace Trell.Animation.Core 
{
    public interface IAnimationTrigger
    {
        void UseOn(Animator animator);
    }
}