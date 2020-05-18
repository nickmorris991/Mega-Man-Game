using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class GutsManYellowBlock : IBlock
    {

        public ISprite BlockSprite;
        private Vector2 Location;

        public GutsManYellowBlock(Vector2 location)
        {
            this.Location = location;
            this.BlockSprite = BlockSpriteFactory.Instance.CreateGutsManYellowBlockSprite();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.BlockSprite.Draw(spriteBatch, Location);
        }

        public Rectangle GetRectangle()
        {
            return BlockSprite.GetCurrentRectangle();
        }
    }
}
