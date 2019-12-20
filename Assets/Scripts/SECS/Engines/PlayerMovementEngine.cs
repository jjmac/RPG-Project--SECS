using RPG.SECS.EntityViews;
using Svelto.ECS;
using System.Collections;

namespace RPG.SECS.Engines
{
    public class PlayerMovementEngine : IQueryingEntitiesEngine
    {
        public IEntitiesDB entitiesDB { set; private get; }

        public void Ready() { Tick().Run(); }

        IEnumerator Tick()
        {
            while (true)
            {
                var targets = entitiesDB.QueryEntities<TargetEntityView>(Groups.Target, out var targetCount);

                if (targetCount > 0)
                {
                    var players = entitiesDB.QueryEntities<PlayerEntityView>(Groups.Player, out var playerCount);
                    if (players.Length > 0)
                    {
                        players[0].movementComponent.navMeshDestination = targets[0].targetPositionComponent.position;
                    }
                }

                yield return null;
            }
        }
    }
}