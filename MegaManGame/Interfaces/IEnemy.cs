using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame.Interfaces
{
   public interface IEnemy
    {
        void Draw(SpriteBatch spriteBatch);

        void Update();

        Rectangle GetRectangle();
    }
}
