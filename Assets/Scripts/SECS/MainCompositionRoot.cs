using RPG.SECS.Engines;
using RPG.SECS.EntityDescriptors;
using Svelto.Context;
using Svelto.ECS;
using Svelto.ECS.Schedulers.Unity;
using Svelto.ECS.Unity;
using UnityEngine;

namespace RPG.SECS
{
    public class MainCompositionRoot : ICompositionRoot
    {
        EnginesRoot _enginesRoot;
        IEntityFactory _entityFactory;
        UnityEntitySubmissionScheduler _unityEntitySubmissionScheduler;

        public MainCompositionRoot(GameObject player, GameObject target)
        {
            QualitySettings.vSyncCount = 1;

            SetupEngines();
            SetupEntities(player, target);
        }

        public void OnContextCreated<T>(T contextHolder)
        {
        }

        public void OnContextInitialized<T>(T contextHolder)
        {
        }

        public void OnContextDestroyed()
        {
        }

        void SetupEngines()
        {
            _unityEntitySubmissionScheduler = new UnityEntitySubmissionScheduler();
            _enginesRoot = new EnginesRoot(_unityEntitySubmissionScheduler);
            _entityFactory = _enginesRoot.GenerateEntityFactory();

            var entityFunctions = _enginesRoot.GenerateEntityFunctions();

            /*
            var playerInputEngine = new PlayerInputEngine();

            _enginesRoot.AddEngine(playerInputEngine);
            */

            var playerMovementEngine = new PlayerMovementEngine();

            _enginesRoot.AddEngine(playerMovementEngine);
        }

        void SetupEntities(GameObject player, GameObject target)
        {
            BuildEntity<PlayerEntityDescriptor>(player, Groups.Player);
            BuildEntity<TargetEntityDescription>(target, Groups.Target);
        }

        EntityStructInitializer BuildEntity<TDescriptor>(GameObject gameObject, ExclusiveGroup group)
            where TDescriptor : IEntityDescriptor, new()
        {
            var implementors = gameObject.GetComponents<IImplementor>();
            return _entityFactory.BuildEntity<TDescriptor>((uint)gameObject.GetInstanceID(), group, implementors);
        }
    }
}
