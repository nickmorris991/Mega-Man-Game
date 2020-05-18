using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    class PlayerJumpingShootingCommand : ICommand
    {
        private Game1 MyGame;
        private bool Reversed;
        public PlayerJumpingShootingCommand(Game1 game, bool reversed)
        {
            MyGame = game;
            this.Reversed = reversed;
          
        }
        public void Execute()
        {
            MyGame.Megaman.Jump();
        
        }
    }
}
