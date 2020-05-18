using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    class PlayerRunningShootingCommand : ICommand
    {
        private Game1 MyGame;
        private bool Reversed;
        public PlayerRunningShootingCommand(Game1 game, bool reversed)
        {
            MyGame = game;
            this.Reversed = reversed;
 
        }
        public void Execute()
        {
            MyGame.Megaman.Run();
            MyGame.Megaman.Shoot();
        }
    }
}
