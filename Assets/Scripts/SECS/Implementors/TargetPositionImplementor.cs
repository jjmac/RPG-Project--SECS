using RPG.SECS.Components;
using Svelto.ECS.Unity;
using UnityEngine;

namespace RPG.SECS.EntityImplementors
{
    public class TargetPositionImplementor : MonoBehaviour, IImplementor, IPositionComponent
    {
        Transform _transform;

        public Vector3 position { get { return _transform.position; } }

        void Awake()
        {
            _transform = transform;
        }
    }
}
