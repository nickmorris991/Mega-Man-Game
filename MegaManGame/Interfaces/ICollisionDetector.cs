using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaManGame.Interfaces
{
    public interface ICollisionDetector
    {
        bool IsColliding(Rectangle object1, Rectangle object2);

        
        ICollision CreateCollision(Rectangle object1, Rectangle object2);

        void Update();
    }
}
