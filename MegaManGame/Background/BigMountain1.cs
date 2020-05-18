using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class BigMountain1 : IBackground
    {
        private ISprite BackgroundSprite;
        private Vector2 Location;

        public BigMountain1(Vector2 location)
        {
            this.Location = location;
            this.BackgroundSprite = BackgroundSpriteFactory.Instance.CreateBigMountain1Sprite();

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            this.BackgroundSprite.Draw(spriteBatch, Location);
        }
    }
}
