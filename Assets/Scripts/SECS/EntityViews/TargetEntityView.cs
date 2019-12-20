using RPG.SECS.Components;
using Svelto.ECS;
using Svelto.ECS.Hybrid;

namespace RPG.SECS.EntityViews
{
    public struct TargetEntityView : IEntityViewStruct
    {
        public IPositionComponent targetPositionComponent;
        public EGID ID { get; set; }
    }
}
