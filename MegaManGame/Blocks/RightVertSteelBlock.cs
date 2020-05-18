using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class RightVertSteelBlock : IBlock
    {

        private ISprite BlockSprite;
        private Vector2 Location;

        public RightVertSteelBlock(Vector2 location)
        {
            this.Location = location;
            this.BlockSprite = BlockSpriteFactory.Instance.CreateRightVertSteelBlockSprite();

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
