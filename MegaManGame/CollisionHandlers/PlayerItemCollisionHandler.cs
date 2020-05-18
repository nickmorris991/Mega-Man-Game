using MegaManGame.Interfaces;
using Microsoft.Xna.Framework;


namespace MegaManGame.CollisionHandlers
{
    class PlayerItemCollisionHandler
    {
        Rectangle areaOfOverlap;
        public PlayerItemCollisionHandler()
        {

        }
        public void HandleCollision(IPlayer player, IItem item, ICollision collisionType)
        {
            areaOfOverlap = Rectangle.Intersect(player.GetRectangle(), item.GetRectangle());
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
            else
            {
                player.UpdateLocation(0, areaOfOverlap.Height);
            }

        }
    }
}
