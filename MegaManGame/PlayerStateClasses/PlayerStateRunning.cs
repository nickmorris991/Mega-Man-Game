
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace MegaManGame
{
    class PlayerStateRunning : IPlayerState
    {
        private IPlayer player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateRunning(IPlayer player)
        {
            this.player = player;
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerRunningSprite(false, this.location));
            reverse = false;
        }

        public void Jump()
        {
            player.PlayerState = new PlayerStateJumping(player);
        }

        public void Run()
        {
            // already running
        }

        public void Shoot()
        {
            player.PlayerState = new PlayerStateRunningShooting(player);
        }

        public void Stand()
        {
            player.PlayerState = new PlayerStateIdle(player);
        }

        public void ChangeDirection()
        {
            player.PlayerState = new PlayerStateRunningReversed(player);
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
