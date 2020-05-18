using MegaManGame.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaManGame
{
    class Collision:ICollision
    {
        private string typeOfCollision;
        private Rectangle areaOfOverlap;
        public Collision(string stringOfType, Rectangle overlap)
        {
            typeOfCollision = stringOfType;
            areaOfOverlap = overlap;

        }

        public string GetCollisionType()
        {
            return typeOfCollision;
        }

        public Rectangle GetOverlap()
        {
            return areaOfOverlap;
        }

        public bool SameTypeOfCollision(ICollision second)
        {
            return typeOfCollision.Equals(second.GetCollisionType());
        }
        
    }
}
