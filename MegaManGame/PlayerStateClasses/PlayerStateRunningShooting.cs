
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateRunningShooting : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateRunningShooting(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerRunningShootingSprite(false, this.location));
            reverse = false;
        }

        public void Jump()
        {
            player.PlayerState = new PlayerStateJumpingShooting(player);
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
            player.PlayerState = new PlayerStateIdleShooting(player);
        }

        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateRunningShootingReversed(player);
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
