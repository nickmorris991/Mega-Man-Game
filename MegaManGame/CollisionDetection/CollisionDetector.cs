using MegaManGame.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Rectangle = Microsoft.Xna.Framework.Rectangle;
using System.Diagnostics;

namespace MegaManGame.CollisionDetection
{
    class CollisionDetector : ICollisionDetector
    {

        private Texture2D sprite;
        public Vector2 Position;
        public ICollision typeOfCollision;
        public bool IsColliding(Rectangle object1, Rectangle object2)
        {
            return object1.Intersects(object2);
        }

        public ICollision CreateCollision(Rectangle object1, Rectangle object2)
        {
            String collisionType = "";
            if(IsTouchingLeft(object1, object2))
            {
                Debug.WriteLine("Left");
                collisionType = "Left";
            }
            else if (IsTouchingRight(object1, object2))
            {
                Debug.WriteLine("Right");
                collisionType = "Right";
            }
            else if (IsTouchingBottom(object1, object2))
            {
                Debug.WriteLine("Bottom");
                collisionType = "Bottom";
            }
            else if (IsTouchingTop(object1, object2))
            {
                Debug.WriteLine("Above");
                collisionType = "Above";
            }
            typeOfCollision = new Collision(collisionType, object1);
            return typeOfCollision;
        }

        public Rectangle Rectangle
        {
            get // Nathan: I used get when I created this method so that we could use this rectangle in this class scope.
            {
                return new Rectangle((int)Position.X, (int)Position.Y, sprite.Width, sprite.Height);
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        protected bool IsTouchingLeft(Rectangle object1, Rectangle object2)
        {
            if (object1.Top < object2.Top)
            {
                return (object1.Left < object2.Left) && (object1.Top < object2.Bottom + 5) && (object1.Bottom > object2.Top + 5);
            } else
            {
                return (object1.Left < object2.Left) && (object1.Top < object2.Bottom - 5) && (object1.Bottom > object2.Top - 5);
            }
        }

        protected bool IsTouchingRight(Rectangle object1, Rectangle object2)
        {
            if (object1.Bottom < object2.Bottom) {
                return (object1.Right > object2.Right) && (object1.Top < object2.Bottom + 5) && (object1.Bottom > object2.Top + 5);
            } else
            {
                return (object1.Right > object2.Right) && (object1.Top < object2.Bottom - 5) && (object1.Bottom > object2.Top - 5);
            }
        }

        protected bool IsTouchingTop(Rectangle object1, Rectangle object2)
        {
            return (object1.Top < object2.Top) && (object1.Right > object2.Left) && (object1.Left < object2.Right);
        }

        protected bool IsTouchingBottom(Rectangle object1, Rectangle object2)
        {
            return (object1.Bottom > object2.Bottom) && (object1.Right > object2.Left) && (object1.Left < object2.Right);
        }


    }
}
