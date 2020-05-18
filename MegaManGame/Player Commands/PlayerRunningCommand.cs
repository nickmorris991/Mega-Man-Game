using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    class PlayerRunningCommand : ICommand
    {
        private Game1 MyGame;
        private bool Reversed;
        public PlayerRunningCommand(Game1 game, bool reversed)
        {
            MyGame = game;
            this.Reversed = reversed;

        }
        public void Execute()
        {
            MyGame.Megaman.Run();
        }
    }
}
