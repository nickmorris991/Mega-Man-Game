
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateRunningReversed : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateRunningReversed(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerRunningSprite(true, this.location));
            reverse = true;
        }

        public void Jump()
        {
            player.PlayerState = new PlayerStateJumpingReversed(player);
        }

        public void Run()
        {
            // already running
        }

        public void Shoot()
        {
            player.PlayerState = new PlayerStateRunningShootingReversed(player);
        }

        public void Stand()
        {
            player.PlayerState = new PlayerStateIdleReversed(player);
        }

        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateRunning(player);
        }

        public void Update()
        {
            //player.Run();
        }

        public bool GetDirection()
        {
            return reverse;
        }
    }
}