using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    class PlayerJumpingCommand : ICommand
    {
        private Game1 MyGame;
    
        private bool Reversed;
        public PlayerJumpingCommand(Game1 game, bool reversed)
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
