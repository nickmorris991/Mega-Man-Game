using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame.Enemy_Sprites
{
    public abstract class AbstractEnemy : ISprite
    {
        public Texture2D EnemyTexture { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
        public int CurrentFrame { get; set; }

        public Rectangle currentCollisionRectangle { get; set; }

        // in case we want to update them in different ways in the future
        public abstract void Update(Vector2 location);
        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            
            int width = EnemyTexture.Width / Columns;
            int height = EnemyTexture.Height / Rows;
            int Row = (int)((float)CurrentFrame / (float)Columns);
            int Column = CurrentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * Column, height * Row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            currentCollisionRectangle = destinationRectangle;
            spriteBatch.Draw(EnemyTexture, destinationRectangle, sourceRectangle, Color.White);

        }

        public Rectangle GetCurrentRectangle()
        {
            return currentCollisionRectangle;
        }
    }
}
