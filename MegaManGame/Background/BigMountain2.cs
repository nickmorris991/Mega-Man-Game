using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class BigMountain2 : IBackground
    {
        private ISprite BackgroundSprite;
        private Vector2 Location;

        public BigMountain2(Vector2 location)
        {
            this.Location = location;
            this.BackgroundSprite = BackgroundSpriteFactory.Instance.CreateBigMountain2Sprite();

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            this.BackgroundSprite.Draw(spriteBatch, Location);
        }
    }
}
