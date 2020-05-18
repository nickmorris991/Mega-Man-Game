using Microsoft.Xna.Framework;
using System;


namespace MegaManGame.Interfaces
{
    public interface ICollision
    {
        bool SameTypeOfCollision(ICollision second);
        Rectangle GetOverlap();

        String GetCollisionType();
    }
}
