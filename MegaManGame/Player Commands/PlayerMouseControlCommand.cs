using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    class PlayerMouseControlCommand : ICommand
    {
        private Game1 MyGame;
        private bool Reversed;
        public PlayerMouseControlCommand(Game1 game)
        {
            MyGame = game;
          
        }
        public void Execute()
        {
            MyGame.Megaman.MouseControl();


        }
    }
}
