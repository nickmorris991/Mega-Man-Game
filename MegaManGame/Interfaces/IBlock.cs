using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public interface IBlock
    {
        
        void Draw(SpriteBatch spriteBatch);
        Rectangle GetRectangle();

    }
}
