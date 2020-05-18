using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MegaManGame
{
    public interface IItem
    {
      
        void Draw(SpriteBatch spriteBatch);
        void Update();
        Rectangle GetRectangle();
    }
}
