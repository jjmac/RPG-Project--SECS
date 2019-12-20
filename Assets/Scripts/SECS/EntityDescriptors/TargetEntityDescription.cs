using RPG.SECS.EntityViews;
using Svelto.ECS;

namespace RPG.SECS.EntityDescriptors
{
    public class TargetEntityDescription : IEntityDescriptor
    {
        static readonly IEntityBuilder[] _entitiesToBuild =
        {
            new EntityBuilder<TargetEntityView>(),
        };

        public IEntityBuilder[] entitiesToBuild => _entitiesToBuild;
    }
}
