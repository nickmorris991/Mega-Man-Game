using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame.Enemy_Sprites
{
   public class EnemySpriteFactory : ISpriteFactory
    {
        private Texture2D BluePogoSpriteSheet;
        private Texture2D GreenFlyingSpriteSheet;
        private Texture2D YellowHelmetSpriteSheet;
        private Texture2D YellowMinerSpriteSheet;
        private Texture2D GutsManSpriteSheet;

        private static EnemySpriteFactory instance { get; } = new EnemySpriteFactory();

        public static EnemySpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        private EnemySpriteFactory()
        {
        }
        public void LoadAllTextures(ContentManager content)
        {
            GreenFlyingSpriteSheet = content.Load<Texture2D>("GreenFlyingEnemySprites");
            YellowHelmetSpriteSheet = content.Load<Texture2D>("YellowHelmetEnemySprite");
            YellowMinerSpriteSheet = content.Load<Texture2D>("YellowMinerEnemySprite");
            GutsManSpriteSheet = content.Load<Texture2D>("Gutsman");
            BluePogoSpriteSheet = content.Load<Texture2D>("BluePogoEnemySprite");
        }

        public ISprite CreateGreenFlyingSprite()
        {
            return new GreenFlyingSprite()
            {
                EnemyTexture = GreenFlyingSpriteSheet,
                Columns = 2,
                Rows = 1,
                CurrentFrame = 0
            }; ;
        }
        public ISprite CreateYellowHelmetSprite()
        {
            return new YellowHelmetSprite()
            {
                EnemyTexture = YellowHelmetSpriteSheet,
                Columns = 2,
                Rows = 1,
                CurrentFrame = 0
            }; ;
        }
        public ISprite CreateYellowMinerSprite()
        {
            return new YellowMiningSprite()
            {
                EnemyTexture = YellowMinerSpriteSheet,
                Columns = 3,
                Rows = 1,
                CurrentFrame = 0
            }; ;
        }

        public ISprite CreateBluePogoSprite()
        {
            return new BluePogoSprite()
            {
                EnemyTexture = BluePogoSpriteSheet,
                Columns = 1,
                Rows = 2,
                CurrentFrame = 0
            }; ;
        }
        public ISprite CreateGutsMan()
        {
            return new GutsManSprite()
            {
                EnemyTexture = GutsManSpriteSheet,
                Columns = 7,
                Rows = 1,
                CurrentFrame = 0
            }; ;
        }
    }
}
