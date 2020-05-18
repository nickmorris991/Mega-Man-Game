using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public abstract class AbstractBlock : ISprite
    {
        public Texture2D BlockTexture { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
        public int CurrentFrame { get; set; }

        public Rectangle currentCollisionRectangle { get; set; }
        public abstract void Update(Vector2 location);
        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = BlockTexture.Width / Columns;
            int height = BlockTexture.Height / Rows;
            int row = (int)((float)CurrentFrame / (float)Columns);
            int column = CurrentFrame % Columns;
            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            currentCollisionRectangle = destinationRectangle;
            spriteBatch.Draw(BlockTexture, destinationRectangle, sourceRectangle, Color.White);
        }

        public Rectangle GetCurrentRectangle()
        {
            return currentCollisionRectangle;
        }
    }
}
