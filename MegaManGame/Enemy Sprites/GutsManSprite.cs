using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame.Enemy_Sprites
{
    class GutsManSprite : AbstractEnemy
    {
        private int ToSlowDownFPS = 0;
        private int Delay = 12;
        public int TotalFrames;

        override public void Update(Vector2 location)
        {
            TotalFrames = Rows * Columns;
            if (ToSlowDownFPS % Delay == 0)
            {
                CurrentFrame++;
                if (CurrentFrame == TotalFrames)
                {
                    CurrentFrame = 0;
                }
            }
            ToSlowDownFPS++;
        }
    }
}
