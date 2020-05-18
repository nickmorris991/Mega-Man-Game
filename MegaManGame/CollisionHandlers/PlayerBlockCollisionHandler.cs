using MegaManGame.Interfaces;
using Microsoft.Xna.Framework;

namespace MegaManGame.CollisionHandlers
{
    class PlayerBlockCollisionHandler
    {
        Rectangle areaOfOverlap;
        public PlayerBlockCollisionHandler()
        {
        }
        public void HandleCollision(IPlayer player, IBlock block, ICollision collisionType) 
        {
            areaOfOverlap = Rectangle.Intersect(player.GetRectangle(), block.GetRectangle());
            if (collisionType.GetCollisionType().Equals("Above"))
            {
                int temp = -1 * (areaOfOverlap.Height);
                player.UpdateLocation(0, temp);
            }
            else if (collisionType.GetCollisionType().Equals("Right"))
            {
                player.UpdateLocation(areaOfOverlap.Width, 0);

            }
            else if (collisionType.GetCollisionType().Equals("Left"))
            {
                player.UpdateLocation(-(areaOfOverlap.Width), 0);
            }
            else if (collisionType.GetCollisionType().Equals("Bottom"))
            {
                player.UpdateLocation(0, areaOfOverlap.Height);
            }

        }
    }
}
