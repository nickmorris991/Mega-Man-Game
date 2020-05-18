using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class HealthBar : IItem
    {

        private ISprite BlockSprite; // this will be added at a later time
        private Vector2 Location;

        public HealthBar(Vector2 location)
        {
            this.Location = location;
            //this.blockSprite = ItemSpriteFactory.Instance.CreateHealthBarSprite();

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
