using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public interface ISprite
    {
        void Draw(SpriteBatch spriteBatch, Vector2 location);
        void Update(Vector2 location);

        Rectangle GetCurrentRectangle();
    }
}
