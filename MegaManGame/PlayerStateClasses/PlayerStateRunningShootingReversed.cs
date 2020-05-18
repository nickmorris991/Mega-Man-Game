
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateRunningShootingReversed : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateRunningShootingReversed(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerRunningShootingSprite(true, this.location));
            reverse = true;
        }

        public void Jump()
        {
            player.PlayerState = new PlayerStateJumpingShootingReversed(player);
        }

        public void Run()
        {
            // already running
        }

        public void Shoot()
        {
            // already shooting
        }

        public void Stand()
        {
            player.PlayerState = new PlayerStateIdleShootingReversed(player);
        }

        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateRunningShooting(player);
        }

        public void Update()
        {
            player.Run();
            player.Shoot();
        }
        public bool GetDirection()
        {
            return reverse;
        }
    }
}
