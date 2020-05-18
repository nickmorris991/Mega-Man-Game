using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public interface IPlayer
    {
        IPlayerState PlayerState { get; set; }
        void SetSprite(ISprite sprite);
        void ChangeDirection();

        Rectangle GetRectangle();
        void UpdateLocation(int deltaX, int deltaY);
        void Stand();
        void Shoot();
        void Jump();
        void Run();
        void MouseControl();
        void Update();
        void Draw(SpriteBatch spriteBatch);

    }
}
