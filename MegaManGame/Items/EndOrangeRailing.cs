using MegaManGame.Item_Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class EndOrangeRailing : IItem
    {
        private ISprite BlockSprite;
        private Vector2 Location;

        public EndOrangeRailing(Vector2 location)
        {
            this.Location = location;
            this.BlockSprite = ItemSpriteFactory.Instance.CreateEndOrangeRailingSprite();

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
