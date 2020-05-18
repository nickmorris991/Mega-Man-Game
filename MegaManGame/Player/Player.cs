using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MegaManGame
{
    class Player : IPlayer
    {
        private ISprite playerSprite;
       
        public IPlayerState PlayerState { get; set; }
        public Vector2 location;  // public for testing purposes     fix later
        private bool isFacingRight = false;
        //private float speed = 5;

        public Player(Game1 game, Vector2 location)
        {
            playerSprite = PlayerSpriteFactory.Instance.CreatePlayerIdleSprite(true, location);
            PlayerState = new PlayerStateIdle(this);
            this.location = location;
        }
        public void SetSprite(ISprite sprite)
        {
            playerSprite = sprite;
        }
        public void Update()
        {
            playerSprite.Update(this.location);
            PlayerState.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            playerSprite.Draw(spriteBatch, this.location);
        }

        public void ChangeDirection()
        {
            isFacingRight = !isFacingRight;
            PlayerState.ChangeDirection();
        }
       
        public void UpdateLocation(int deltaX, int deltaY)
        {
            this.location = new Vector2(this.location.X + deltaX, this.location.Y + deltaY);
        }
        
        public void Stand()
        {
            PlayerState.Stand();
        }

        public void Shoot()
        {
            PlayerState.Shoot();
        }

        public void Jump()
        {
            PlayerState.Jump();
        }

        public void Run()
        {
           
            PlayerState.Run();
        }


        public void MouseControl()
        {

            this.location.X = Mouse.GetState().X;
            this.location.Y = Mouse.GetState().Y;
        }

        Rectangle IPlayer.GetRectangle()
        {
            return playerSprite.GetCurrentRectangle();
        }
    }
}
