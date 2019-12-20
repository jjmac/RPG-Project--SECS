using UnityEngine;

namespace RPG.SECS.Components
{
    public interface IPlayerMovementComponent
    {
        Vector3 navMeshDestination { set; }
    }
}
