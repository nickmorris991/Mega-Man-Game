using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class PlayerIdleShootingSprite : ISprite
    {
        Texture2D Texture { get; set; }
        Vector2 Location;
        Rectangle currentRectangle;
        int HorizontalCoordinate;
        int VerticalCoordinate;
        int HorizontalSize;
        int VerticalSize;
        bool Reversed;

        public PlayerIdleShootingSprite(Texture2D texture, Vector2 printLocation, bool reversed)
        {
            Texture = texture;
            Location = printLocation;
            Reversed = reversed;
            
            HorizontalCoordinate = 292;
            VerticalCoordinate = 9;
            HorizontalSize = 32;
            VerticalSize = 24;
            currentRectangle = new Rectangle(HorizontalCoordinate, VerticalCoordinate, HorizontalSize, VerticalSize);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(HorizontalCoordinate, VerticalCoordinate, HorizontalSize, VerticalSize);
            Rectangle destinationRectangle = new Rectangle((int)Location.X, (int)Location.Y, 40, 40);
            currentRectangle = destinationRectangle;
            if (!Reversed)
            {
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
            }
            else
            {
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.FlipHorizontally, 0f);
            }
        }

        public void Update(Vector2 location)
        {
            this.Location = location;
        }

        public Rectangle GetCurrentRectangle()
        {
            return currentRectangle;
        }
    }
}
