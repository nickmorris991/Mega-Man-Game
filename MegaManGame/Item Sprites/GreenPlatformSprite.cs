using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame.Item_Sprites
{
    public class GreenPlatformSprite : AbstractItem
    {
      
        private int ToSlowDownFPS = 0;
        private int Delay = 17;
        private int TotalFrames; 
        
        private void AnimatePlatform()
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
        

        override public void Update (Vector2 location)
        {
            AnimatePlatform();
        }
   
    }
}
