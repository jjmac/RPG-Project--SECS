using Svelto.ECS;

namespace RPG.SECS
{
    public class Groups
    {
        public static readonly ExclusiveGroup Player = new ExclusiveGroup();
        public static readonly ExclusiveGroup Target = new ExclusiveGroup();

        // The camera target is the player.
        public static readonly ExclusiveGroup CameraTarget = Player;
    }
}