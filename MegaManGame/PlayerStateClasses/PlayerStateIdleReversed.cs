using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    class PlayerStateIdleReversed : IPlayerState
    {
     
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateIdleReversed(IPlayer player)
        {
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerIdleSprite(true, this.location));
            this.player = player;
            reverse = true;
         
        }

        public void Jump()
        {
            this.player.PlayerState = new PlayerStateJumpingReversed(player); 
        }

        public void Run()
        {
            this.player.PlayerState = new PlayerStateRunningReversed(player);
        }

        public void Shoot()
        {
            this.player.PlayerState = new PlayerStateIdleShootingReversed(player);
        }

        public void Stand()
        {
            // current state
        }
        public void ChangeDirection()
        {
            this.player.PlayerState = new PlayerStateIdle(player);
        }

        public void Update()
        {
            this.player.Stand();
        }
        public bool GetDirection()
        {
            return reverse;
        }
    }
}
