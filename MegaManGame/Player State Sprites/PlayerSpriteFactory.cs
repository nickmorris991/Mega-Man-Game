using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MegaManGame
{
    public class PlayerSpriteFactory : ISpriteFactory
    {
        private Texture2D MegaManSpriteSheet;

        //private Vector2 PrintLocation;

        private static PlayerSpriteFactory instance { get; } = new PlayerSpriteFactory();

        public static PlayerSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        private PlayerSpriteFactory()
        {
        }
        public void LoadAllTextures(ContentManager content)
        {
            MegaManSpriteSheet = content.Load<Texture2D>("MegaManSpriteSheet");
            
        }
        public ISprite CreatePlayerIdleSprite(bool reversed, Vector2 location)
        {
            return new PlayerIdleSprite(MegaManSpriteSheet, location, reversed);
        }
        public ISprite CreatePlayerJumpingShootingSprite(bool reversed, Vector2 location)
        {
            return new PlayerJumpingShootingSprite(MegaManSpriteSheet, location, reversed);
        }
        public ISprite CreatePlayerJumpingSprite(bool reversed, Vector2 location)
        {
            return new PlayerJumpingSprite(MegaManSpriteSheet, location, reversed);
        }
        public ISprite CreatePlayerIdleShootingSprite(bool reversed, Vector2 location)
        {
            return new PlayerIdleShootingSprite(MegaManSpriteSheet, location, reversed);
        }
        public ISprite CreatePlayerRunningSprite(bool reversed, Vector2 location)
        {
            return new PlayerRunningSprite(MegaManSpriteSheet, location, reversed);
        }
        public ISprite CreatePlayerRunningShootingSprite(bool reversed, Vector2 location)
        {
            return new PlayerRunningShootingSprite(MegaManSpriteSheet, location, reversed);
        }
      
    }
}
