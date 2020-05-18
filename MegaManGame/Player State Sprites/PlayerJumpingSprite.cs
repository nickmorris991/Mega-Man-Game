using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class PlayerJumpingSprite : ISprite
    {

        Texture2D Texture { get; set; }
        Vector2 Location;
        private Rectangle currentRectangle;
        int HorizontalCoordinate;
        int VerticalCoordinate;
        int HorizontalSize;
        int VerticalSize;
        bool Reversed;

        public PlayerJumpingSprite(Texture2D texture, Vector2 PrintLocation, bool reversed)
        {
            Texture = texture;
            Location = PrintLocation;
            Reversed = reversed;

            HorizontalCoordinate = 192;
            VerticalCoordinate = 1;
            HorizontalSize = 32;
            VerticalSize = 32;
            currentRectangle=new Rectangle(HorizontalCoordinate, VerticalCoordinate, HorizontalSize, VerticalSize);
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
