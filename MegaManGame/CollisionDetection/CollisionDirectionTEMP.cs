using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace MegaManGame
{
    public class CollisionDetectionTEMP
    {
        protected Texture2D Sprite;
        public Vector2 Position;
        public Vector2 Velocity;


        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.Width, Sprite.Height);
            }
        }

        protected bool IsTouchingLeft(CollisionDetectionTEMP sprite)
        {
            Debug.WriteLine("Left");
            return this.Rectangle.Right + this.Velocity.X > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Left &&
              this.Rectangle.Bottom > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Bottom;
        }

        protected bool IsTouchingRight(CollisionDetectionTEMP sprite)
        {
            Debug.WriteLine("Right");
            return this.Rectangle.Left + this.Velocity.X < sprite.Rectangle.Right &&
              this.Rectangle.Right > sprite.Rectangle.Right &&
              this.Rectangle.Bottom > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Bottom;
        }

        protected bool IsTouchingTop(CollisionDetectionTEMP sprite)
        {
            Debug.WriteLine("Top");
            return this.Rectangle.Bottom + this.Velocity.Y > sprite.Rectangle.Top &&
              this.Rectangle.Top < sprite.Rectangle.Top &&
              this.Rectangle.Right > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Right;
        }

        protected bool IsTouchingBottom(CollisionDetectionTEMP sprite)
        {
            Debug.WriteLine("Bottom");
            return this.Rectangle.Top + this.Velocity.Y < sprite.Rectangle.Bottom &&
              this.Rectangle.Bottom > sprite.Rectangle.Bottom &&
              this.Rectangle.Right > sprite.Rectangle.Left &&
              this.Rectangle.Left < sprite.Rectangle.Right;
        }
    }
}