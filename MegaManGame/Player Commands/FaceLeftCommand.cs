namespace MegaManGame.Player_Commands
{
    class FaceLeftCommand : ICommand
    {
        private Game1 myGame;
        private int speed;
        public FaceLeftCommand(Game1 game)
        {
            myGame = game;
            speed = -5;
        }
        public void Execute()
        {
            
            if (myGame.Megaman.PlayerState.GetDirection())
            {
                myGame.Megaman.ChangeDirection();
            }
            
            
            else {
                myGame.Megaman.UpdateLocation(speed, 0);
                myGame.Megaman.Run();
            }
        }
    }
}
