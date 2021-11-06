using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Assertions;
using Sirenix.OdinInspector;

namespace Trell.Animation.Core
{
    public class TrellAnimator : SerializedMonoBehaviour
    {
        [SerializeField] private List<IAnimationTrigger> _animationTriggers;

        private Dictionary<Type, IAnimationTrigger> _cash = new Dictionary<Type, IAnimationTrigger>();

        public IAnimationTrigger GetAnimationTrigger<T>() where T : IAnimationTrigger
        {
            Type type = typeof(T);
            if (_cash.ContainsKey(type))
            {
                return _cash[type];
            }
            var animationTrigger = _animationTriggers.Find(x => x.GetType() == type);
          
            Assert.IsNotNull(animationTrigger, "The trigger wasn't find");
            
            _cash.Add(type, animationTrigger);
            return animationTrigger;
        }
    }
}