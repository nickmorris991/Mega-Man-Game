using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaManGame
{
    class BackgroundSpriteFactory
    {
        private Texture2D BigMountain1SpriteSheet;
        private Texture2D BigMountain2SpriteSheet;
        private Texture2D Cloud1SpriteSheet;

        private static BackgroundSpriteFactory instance { get; } = new BackgroundSpriteFactory();

        public static BackgroundSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private BackgroundSpriteFactory()
        {
        }
        public void LoadAllTextures(ContentManager content)
        {
            BigMountain1SpriteSheet = content.Load<Texture2D>("BigMountain1SpriteSheet");
            BigMountain2SpriteSheet = content.Load<Texture2D>("BigMountain2");
            Cloud1SpriteSheet = content.Load<Texture2D>("MegaManCloudSprite");
        }

        public ISprite CreateBigMountain1Sprite()
        {
            return new BigMountain1Sprite()
            {
                BackgroundTexture = BigMountain1SpriteSheet,
                Columns = 1,
                Rows = 1,
                CurrentFrame = 0
            };
        }
        public ISprite CreateBigMountain2Sprite()
        {
            return new BigMountain2Sprite()
            {
                BackgroundTexture = BigMountain2SpriteSheet,
                Columns = 1,
                Rows = 1,
                CurrentFrame = 0
            };
        }

        public ISprite CreateCloud1Sprit()
        {
            return new Cloud1Sprite()
            {
                BackgroundTexture = Cloud1SpriteSheet,
                Columns = 1,
                Rows = 1,
                CurrentFrame = 0
            };
        }
    }
}
