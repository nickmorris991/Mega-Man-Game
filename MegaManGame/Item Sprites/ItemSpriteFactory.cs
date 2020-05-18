using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame.Item_Sprites
{
    public class ItemSpriteFactory : ISpriteFactory
    {
       private Texture2D HealthBarSpriteSheet; // not currently used
        private Texture2D GreenPlatformSpriteSheet;
        private Texture2D ThickOrangeRailingSpriteSheet;
        private Texture2D SkinnyOrangeRailingSpriteSheet;
        private Texture2D EndOrangeRailingSpriteSheet;

        private static ItemSpriteFactory instance { get; } = new ItemSpriteFactory();

        public static ItemSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        private ItemSpriteFactory()
        {
        }
        public void LoadAllTextures(ContentManager content)
        {
            ThickOrangeRailingSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            SkinnyOrangeRailingSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            EndOrangeRailingSpriteSheet = content.Load<Texture2D>("BigBlockSheet");
            GreenPlatformSpriteSheet = content.Load<Texture2D>("GreenDoorSpriteSheet (2)");
        }
        public ISprite CreateThickOrangeRailingSprite()
        {
            return new ThickOrangeRailingSprite()
            {
                ItemTexture = ThickOrangeRailingSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 21
            }; 
        }
        public ISprite CreateSkinnyOrangeRailingSprite()
        {
            return new SkinnyOrangeRailingSprite()
            {
                ItemTexture = SkinnyOrangeRailingSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 22
            };
        }
        public ISprite CreateEndOrangeRailingSprite()
        {
            return new EndOrangeRailingSprite()
            {
                ItemTexture = EndOrangeRailingSpriteSheet,
                Columns = 5,
                Rows = 8,
                CurrentFrame = 20
            };
        }
        public ISprite CreateGreenPlatformSprite()
        {
            return new GreenPlatformSprite()
            {
                ItemTexture = GreenPlatformSpriteSheet,
                Columns = 3,
                Rows = 1,
                CurrentFrame = 0
            };
        }
    }
}
