using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public abstract class AbstractBackground : ISprite
    {
        public Texture2D BackgroundTexture { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
        public int CurrentFrame { get; set; }
        public abstract void Update(Vector2 location);
        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = BackgroundTexture.Width / Columns;
            int height = BackgroundTexture.Height / Rows;
            int row = (int)((float)CurrentFrame / (float)Columns);
            int column = CurrentFrame % Columns;
            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            spriteBatch.Draw(BackgroundTexture, destinationRectangle, sourceRectangle, Color.White);
        }

        public Rectangle GetCurrentRectangle()
        {
            throw new System.NotImplementedException();
        }
    }
}
