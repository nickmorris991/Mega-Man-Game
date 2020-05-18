using Microsoft.Xna.Framework.Graphics;
using System;

namespace MegaManGame
{
    class PlayerIdleCommand : ICommand
    {
        private Game1 MyGame;
        private bool Reversed;
        public PlayerIdleCommand(Game1 game, bool reversed)
        {
            MyGame = game;
            this.Reversed = reversed;
            
        }

        public void Execute()
        {
            MyGame.Megaman.Stand();

        }
    }
}
