namespace MegaManGame.Player_Commands
{
    class MoveUpCommand : ICommand
    {
        private Game1 MyGame;
        private int speed;
        public MoveUpCommand(Game1 game)
        {
            MyGame = game;
            speed = -5;
        }
        public void Execute()
        {
            MyGame.Megaman.UpdateLocation(0, speed);
            MyGame.Megaman.Jump();
        }
    }
}
