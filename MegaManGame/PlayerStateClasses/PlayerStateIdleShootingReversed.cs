
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateIdleShootingReversed : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateIdleShootingReversed(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerIdleShootingSprite(true, this.location));
            reverse = true;
        }

        public void Jump()
        {
            player.PlayerState = new PlayerStateJumpingShootingReversed(player);
        }

        public void Run()
        {
            player.PlayerState = new PlayerStateRunningShootingReversed(player);
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
            player.PlayerState = new PlayerStateIdleShooting(player);
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
