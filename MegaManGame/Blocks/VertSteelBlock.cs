using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    public class VertSteelBlock : IBlock
    {

        private ISprite BlockSprite;
        private Vector2 Location;

        public VertSteelBlock(Vector2 location)
        {
            this.Location = location;
            this.BlockSprite = BlockSpriteFactory.Instance.CreateVertSteelBlockSprite();

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
