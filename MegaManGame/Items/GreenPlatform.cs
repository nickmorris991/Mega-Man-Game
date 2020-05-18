using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MegaManGame.Item_Sprites;

namespace MegaManGame
{
    public class GreenPlatform : IItem
    {

        private ISprite BlockSprite;
        private Vector2 Location;

        public GreenPlatform(Vector2 location)
        {
            this.Location = location;
            this.BlockSprite = ItemSpriteFactory.Instance.CreateGreenPlatformSprite();

        }
        public Rectangle GetRectangle()
        {
            return BlockSprite.GetCurrentRectangle();
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            this.BlockSprite.Draw(spriteBatch, Location);
        }

        public void Update()
        {
            this.BlockSprite.Update(this.Location);
        }

    }
}
