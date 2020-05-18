
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateJumpingShootingReversed : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateJumpingShootingReversed(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerJumpingShootingSprite(true, this.location));
            reverse = true;
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
            player.PlayerState = new PlayerStateIdleReversed(player);
        }

        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateJumpingShooting(player);
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
