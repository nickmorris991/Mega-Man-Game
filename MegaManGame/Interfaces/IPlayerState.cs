namespace MegaManGame
{
    public interface IPlayerState
    {
        void Update();
        void Jump();
        void Run();
        void Shoot();
        void Stand();
        void ChangeDirection();
        bool GetDirection();
    }
}
