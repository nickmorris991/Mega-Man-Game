using System;

namespace MegaManGame
{
    class PlayerIdleShootingCommand : ICommand
    {
        private Game1 MyGame;
        private bool Reversed;
        public PlayerIdleShootingCommand(Game1 game, bool reversed)
        {
            MyGame = game;
            this.Reversed = reversed;
     
        }
        public void Execute()
        {
            
            MyGame.Megaman.Shoot();
        }
    }
}
