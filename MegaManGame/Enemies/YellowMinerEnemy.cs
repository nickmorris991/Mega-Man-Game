using MegaManGame.Enemy_Sprites;
using MegaManGame.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame.Enemies
{
    
    class YellowMinerEnemy:IEnemy
    {
       private ISprite MySprite;
        private Vector2 Location;
    

        public YellowMinerEnemy(Vector2 location)
        {
            MySprite = EnemySpriteFactory.Instance.CreateYellowMinerSprite();
            this.Location = location; 
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            MySprite.Draw(spriteBatch, Location);
        }

        public void Update()
        {
            MySprite.Update(this.Location);
        }
        public Rectangle GetRectangle()
        {
            return MySprite.GetCurrentRectangle();
        }
    }
}
