
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateJumpingReversed : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateJumpingReversed(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerJumpingSprite(true, this.location));
            reverse = true;
        }

        public void Jump()
        {
            // already jumping
        }

        public void Run()
        {
            // cant jump and run
        }

        public void Shoot()
        {
            player.PlayerState = new PlayerStateJumpingShootingReversed(player);
        }

        public void Stand()
        {
            player.PlayerState = new PlayerStateIdleReversed(player);
        }

        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateJumping(player);
        }

        public void Update()
        {
            player.Jump();
        }
        public bool GetDirection()
        {
            return reverse;
        }
    }
}
