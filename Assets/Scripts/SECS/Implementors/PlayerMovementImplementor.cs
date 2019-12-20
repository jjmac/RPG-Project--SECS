using RPG.SECS.Components;
using Svelto.ECS.Unity;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.SECS.EntityImplementors
{
    public class PlayerMovementImplementor : MonoBehaviour, IImplementor, IPlayerMovementComponent
    {
        NavMeshAgent _navMeshAgent;

        public Vector3 navMeshDestination { set { _navMeshAgent.destination = value; } }

        void Awake()
        {
            this._navMeshAgent = GetComponent<NavMeshAgent>();
        }
    }
}