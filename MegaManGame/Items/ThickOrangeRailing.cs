using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MegaManGame.Item_Sprites;

namespace MegaManGame
{
    public class ThickOrangeRailing : IItem
    {
        private ISprite BlockSprite;
        private Vector2 Location;

        public ThickOrangeRailing(Vector2 location)
        {
            this.Location = location;
            this.BlockSprite = ItemSpriteFactory.Instance.CreateThickOrangeRailingSprite();

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
