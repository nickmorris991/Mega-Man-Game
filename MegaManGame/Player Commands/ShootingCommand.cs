using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaManGame.Player_Commands
{
    class ShootingCommand : ICommand
    {
        private Game1 MyGame;
        private bool Reversed;
        public ShootingCommand(Game1 game, bool reversed)
        {
            MyGame = game;
            Reversed = reversed;
        }

        public void Execute()
        {
            MyGame.Megaman.Shoot();
        }
    }
}
