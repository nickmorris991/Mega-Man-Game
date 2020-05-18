using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame.Item_Sprites
{
    public abstract class AbstractItem : ISprite
    {
        public Texture2D ItemTexture { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
        public int CurrentFrame { get; set; }
     

        public Rectangle currentCollisionRectangle { get; set; }
        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = ItemTexture.Width / Columns;
            int height = ItemTexture.Height / Rows;
            int row = (int)((float)CurrentFrame / (float)Columns);
            int column = CurrentFrame % Columns;
            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);
            currentCollisionRectangle = destinationRectangle;
            spriteBatch.Draw(ItemTexture, destinationRectangle, sourceRectangle, Color.White);
        }
        // we'll likely need different update methods
        public abstract void Update(Vector2 location);

        public virtual Rectangle GetCurrentRectangle()
        {
            return currentCollisionRectangle;

        }

    }
}
