using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    class PlayerStateIdle : IPlayerState
    {
        private IPlayer Player;
        private bool reverse;
        private Vector2 location;
        public PlayerStateIdle(IPlayer player)
        {
            player.SetSprite(PlayerSpriteFactory.Instance.CreatePlayerIdleSprite(false, this.location));
            this.Player = player;
            reverse = false;
        }

        public void Jump()
        {
            Player.PlayerState = new PlayerStateJumping(Player);
        }

        public void Run()
        {
            Player.PlayerState = new PlayerStateRunning(Player);
        }

        public void Shoot()
        {
           
            Player.PlayerState = new PlayerStateIdleShooting(Player);
        }

        public void Stand()
        {
            // current state
        }

        public void ChangeDirection()
        {
            Player.PlayerState = new PlayerStateIdleReversed(Player);
        }

        public void Update()
        {
            this.Player.Stand();
        }

        public bool GetDirection()
        {
            return reverse;
        }
    }
}
