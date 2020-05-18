using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class PlayerRunningShootingSprite : ISprite
    {
        private Texture2D Texture { get; set; }
        private int CurrentFrame;
        private int TotalFrames;
        private Rectangle SourceRectangle;
        private Rectangle currentRectangle;
        int SpriteHorizontalSize;
        int SpriteVerticalSize;
        int[] RunningFramesHorizontalLocation;
        int RunningFramesVerticalLocation;
        private Vector2 Location;
        int ToSlowDownFPS;
        int Delay;
        bool Reversed;

        public PlayerRunningShootingSprite(Texture2D texture, Vector2 PrintLocation, bool reversed)
        {
            RunningFramesHorizontalLocation = new int[3];

            Location = PrintLocation;
            Reversed = reversed;

            TotalFrames = 3;

            Texture = texture;
            SpriteHorizontalSize = 32;
            SpriteVerticalSize = 24;

            RunningFramesHorizontalLocation[0] = 325;
            RunningFramesHorizontalLocation[1] = 358;
            RunningFramesHorizontalLocation[2] = 391;
            RunningFramesVerticalLocation = 9;
            ToSlowDownFPS = 0;
            Delay = 17;

            currentRectangle=new Rectangle(RunningFramesHorizontalLocation[0], RunningFramesVerticalLocation, SpriteHorizontalSize, SpriteVerticalSize);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int frame = (int)((float)CurrentFrame);
            switch (frame)
            {
                case 0:
                    SourceRectangle = new Rectangle(RunningFramesHorizontalLocation[0], RunningFramesVerticalLocation, SpriteHorizontalSize, SpriteVerticalSize);
                    break;
                case 1:
                    SourceRectangle = new Rectangle(RunningFramesHorizontalLocation[1], RunningFramesVerticalLocation, SpriteHorizontalSize, SpriteVerticalSize);
                    break;
                case 3:
                    SourceRectangle = new Rectangle(RunningFramesHorizontalLocation[2], RunningFramesVerticalLocation, SpriteHorizontalSize, SpriteVerticalSize);
                    break;
                default:
                    SourceRectangle = new Rectangle(RunningFramesHorizontalLocation[2], RunningFramesVerticalLocation, SpriteHorizontalSize, SpriteVerticalSize);
                    break;
            }

            Rectangle destinationRectangle = new Rectangle((int)Location.X, (int)Location.Y, 40, 40);
            currentRectangle = destinationRectangle;
            if (!Reversed)
            {
                spriteBatch.Draw(Texture, destinationRectangle, SourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
            }
            else
            {
                spriteBatch.Draw(Texture, destinationRectangle, SourceRectangle, Color.White, 0, new Vector2(0, 0), SpriteEffects.FlipHorizontally, 0f);
            }
        }

        public void Update(Vector2 location)
        {
            this.Location = location;
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
        public Rectangle GetCurrentRectangle()
        {
            return currentRectangle;
        }
    }
}
