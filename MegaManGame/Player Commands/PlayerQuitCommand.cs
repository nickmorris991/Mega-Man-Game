namespace MegaManGame
{
    public class PlayerQuitCommand : ICommand
    {
        private Game1 MyGame;
        public PlayerQuitCommand(Game1 game)
        {
            MyGame = game;
        }
        public void Execute()
        {
            MyGame.Exit();
        }
    }
}
