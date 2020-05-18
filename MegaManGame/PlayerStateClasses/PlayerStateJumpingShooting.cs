
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateJumpingShooting : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateJumpingShooting(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerJumpingShootingSprite(false, this.location));
            reverse = false;
        }

        public void Jump()
        {
            // already jumping
        }

        public void Run()
        {
            // cant run and jump
        }

        public void Shoot()
        {
            // already shooting
        }

        public void Stand()
        {
            player.PlayerState = new PlayerStateIdleShooting(player);
        }

        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateJumpingShootingReversed(player);
        }

        public void Update()
        {
            player.Jump();
            player.Shoot();
        }
        public bool GetDirection()
        {
            return reverse;
        }
    }
}
