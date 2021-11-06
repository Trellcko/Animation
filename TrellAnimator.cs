using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Assertions;
using Sirenix.OdinInspector;

namespace Trell.Animation.Core
{
    [RequireComponent(typeof(Animator))]
    public class TrellAnimator : SerializedMonoBehaviour
    {
        [SerializeField] private List<IAnimationTrigger> _animationTriggers;

        private Dictionary<Type, IAnimationTrigger> _cash = new Dictionary<Type, IAnimationTrigger>();
        
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void UseAnimationTrigger<T>() where T : IAnimationTrigger
        {
            Type type = typeof(T);
            if (_cash.ContainsKey(type))
            {
                _cash[type].UseOn(_animator);
            }
            var animationTrigger = _animationTriggers.Find(x => x.GetType() == type);
          
            Assert.IsNotNull(animationTrigger, "The trigger wasn't find");
            
            _cash.Add(type, animationTrigger);
            animationTrigger.UseOn(_animator);
        }
    }
}