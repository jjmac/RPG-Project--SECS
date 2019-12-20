using RPG.SECS.Components;
using Svelto.ECS;
using Svelto.ECS.Hybrid;

namespace RPG.SECS.EntityViews
{
    public struct PlayerEntityView : IEntityViewStruct
    {
        public IPlayerMovementComponent movementComponent;
        // public ITransformComponent transformComponent;

        public EGID ID { get; set; }
    }
}
