using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public class BlockSpriteFactory : ISpriteFactory
    {
        private Texture2D HorizSteelBlockSpriteSheet;
        private Texture2D VertSteelBlockSpriteSheet; 
        private Texture2D LeftVertSteelBlockSpriteSheet;
        private Texture2D RightVertSteelBlockSpriteSheet;
        private Texture2D SpikeSteelBlockSpriteSheet;
        private Texture2D SupportBeamSteelBlockSpriteSheet;
        private Texture2D YellowBlockSpriteSheet;
        private Texture2D GutsManYellowBlockSpriteSheet;

        private static BlockSpriteFactory instance { get; } = new BlockSpriteFactory();

        public static BlockSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        private BlockSpriteFactory()
        {
        }
        public void LoadAllTextures(ContentManager content)
        {
            HorizSteelBlockSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            VertSteelBlockSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            LeftVertSteelBlockSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            RightVertSteelBlockSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            SpikeSteelBlockSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            SupportBeamSteelBlockSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            YellowBlockSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            GutsManYellowBlockSpriteSheet = content.Load<Texture2D>("GutsManYellowBlockSheet (2)");
        }
        public ISprite CreateHorizSteelBlockSprite()
        {
            return new HorizSteelBlockSprite()
            {
                BlockTexture = HorizSteelBlockSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 9
            };
        }
        public ISprite CreateVertSteelBlockSprite()
        {
            return new VertSteelBlockSprite()
            {
                BlockTexture = VertSteelBlockSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 2
            };
        }
        public ISprite CreateLeftVertSteelBlockSprite()
        {
            return new LeftVertSteelBlockSprite()
            {
                BlockTexture = LeftVertSteelBlockSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 24
            };
        }
        public ISprite CreateRightVertSteelBlockSprite()
        {
            return new RightVertSteelBlockSprite()
            {
                BlockTexture = RightVertSteelBlockSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 4
            };
        }
        public ISprite CreateSpikeSteelBlockSprite()
        {
            return new SpikeSteelBlockSprite()
            {
                BlockTexture = SpikeSteelBlockSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 1
            };
        }
        public ISprite CreateSupportBeamSteelBlockSprite()
        {
            return new SupportBeamSteelBlockSprite()
            {
                BlockTexture = SupportBeamSteelBlockSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 3
            };
        }
        public ISprite CreateYellowBlockSprite()
        {
            return new YellowBlockSprite()
            {
                BlockTexture = YellowBlockSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 30
            };
        }
        public ISprite CreateGutsManYellowBlockSprite()
        {
            return new GutsManYellowBlockSprite()
            {
                BlockTexture = GutsManYellowBlockSpriteSheet,
                Columns = 1,
                Rows = 1,
                CurrentFrame = 0
            };
        }
    }
}
