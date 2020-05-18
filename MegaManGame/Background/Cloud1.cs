using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class Cloud1 : IBackground
    {
        private ISprite BackgroundSprite;
        private Vector2 Location;

        public Cloud1(Vector2 location)
        {
            this.Location = location;
            this.BackgroundSprite = BackgroundSpriteFactory.Instance.CreateCloud1Sprit();

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            this.BackgroundSprite.Draw(spriteBatch, Location);
        }
    }
}
