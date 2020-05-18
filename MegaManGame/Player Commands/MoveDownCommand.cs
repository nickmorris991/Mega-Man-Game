using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaManGame.Player_Commands
{
    class MoveDownCommand : ICommand
    {
        private Game1 MyGame;
        private int speed;
        public MoveDownCommand(Game1 game)
        {
            MyGame = game;
            speed = 5;
        }
        public void Execute()
        {
            MyGame.Megaman.UpdateLocation(0, speed);
            MyGame.Megaman.Jump();
        }
    }
}
