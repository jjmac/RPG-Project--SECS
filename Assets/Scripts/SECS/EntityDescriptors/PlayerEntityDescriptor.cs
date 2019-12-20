using RPG.SECS.EntityViews;
using Svelto.ECS;

namespace RPG.SECS.EntityDescriptors
{
    public class PlayerEntityDescriptor : IEntityDescriptor
    {
        static readonly IEntityBuilder[] _entitiesToBuild =
        {
            new EntityBuilder<PlayerEntityView>(),
        };

        public IEntityBuilder[] entitiesToBuild => _entitiesToBuild;
    }
}
