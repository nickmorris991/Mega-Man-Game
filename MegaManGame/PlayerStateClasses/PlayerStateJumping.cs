
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateJumping : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateJumping(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerJumpingSprite(false, this.location));
            reverse = false;
        }

        public void Jump()
        {
            // already jumping
        }

        public void Run()
        {
            // can't jump and run
        }

        public void Shoot()
        {
            player.PlayerState = new PlayerStateJumpingShooting(player);
        }

        public void Stand()
        {
            player.PlayerState = new PlayerStateIdle(player);
        }

        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateJumpingReversed(player);
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
