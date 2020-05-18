
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateIdleShooting : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateIdleShooting(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerIdleShootingSprite(false, this.location));
            reverse = false;
        }

        public void Jump()
        {
            player.PlayerState = new PlayerStateJumpingShooting(player);
        }

        public void Run()
        {
            player.PlayerState = new PlayerStateRunningShooting(player);
        }

        public void Shoot()
        {
            // already shooting
        }

        public void Stand()
        {
            player.PlayerState = new PlayerStateIdle(player);
        }
        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateIdleShootingReversed(player);
        }

        public void Update()
        {
            this.player.Shoot();
        }
        public bool GetDirection()
        {
            return reverse;
        }
    }
}
