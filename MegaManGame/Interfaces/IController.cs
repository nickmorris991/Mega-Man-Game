namespace MegaManGame
{
    public interface IController
    {
        void Update();
        void RegisterCommand(int button, ICommand command);
    }
}
