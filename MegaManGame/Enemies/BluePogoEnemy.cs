using MegaManGame.Enemy_Sprites;
using MegaManGame.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame.Enemies
{
    class BluePogoEnemy:IEnemy
    {
        private ISprite MySprite;
        private Vector2 Location;

        public BluePogoEnemy(Vector2 location)
        {
            this.MySprite = EnemySpriteFactory.Instance.CreateBluePogoSprite();
            this.Location = location;
          
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            MySprite.Draw(spriteBatch, Location);
        }

        public Rectangle GetRectangle()
        {
            return MySprite.GetCurrentRectangle();
        }

        public void Update()
        {
            MySprite.Update(this.Location);
        }
    }
}
