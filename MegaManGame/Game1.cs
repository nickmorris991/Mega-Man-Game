using MegaManGame.Enemy_Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using MegaManGame.Item_Sprites;
using MegaManGame.Player_Commands;

namespace MegaManGame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager Graphics;
        SpriteBatch SpriteBatch;
        public IPlayer Megaman;
        private ILevel Level;
        private List<IController> ControllerList;

        private ICommand PlayerIdle;
        private ICommand Shoot;
        private ICommand GoLeft;
        private ICommand GoRight;
        private ICommand GoDown;
        private ICommand GoUp;
        private ICommand QuitGame;
        private ICommand MouseControl;

        public Game1()
        {
            Graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            ControllerList = new List<IController>();
            ControllerList.Add(new KeyboardController());

            PlayerIdle = new PlayerIdleCommand(this, false);
            GoLeft = new FaceLeftCommand(this);
            GoRight = new FaceRightCommand(this);
            GoDown = new MoveDownCommand(this);
            GoUp = new MoveUpCommand(this);
            Shoot = new ShootingCommand(this, true);
            QuitGame = new PlayerQuitCommand(this);
            MouseControl = new PlayerMouseControlCommand(this);

            ControllerList[0].RegisterCommand((int)Keys.Kanji, PlayerIdle);
            ControllerList[0].RegisterCommand((int)Keys.Up, GoUp);
            ControllerList[0].RegisterCommand((int)Keys.Down, GoDown);
            ControllerList[0].RegisterCommand((int)Keys.A, Shoot);
            ControllerList[0].RegisterCommand((int)Keys.Left, GoLeft);
            ControllerList[0].RegisterCommand((int)Keys.Right, GoRight);
            ControllerList[0].RegisterCommand((int)Keys.Q, QuitGame);
            ControllerList[0].RegisterCommand((int)Keys.M, MouseControl);

            Level = new Level("GutsmanLevelData", Megaman);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            EnemySpriteFactory.Instance.LoadAllTextures(Content);
            PlayerSpriteFactory.Instance.LoadAllTextures(Content);
            BackgroundSpriteFactory.Instance.LoadAllTextures(Content);

            SpriteBatch = new SpriteBatch(GraphicsDevice);
            Megaman = new Player(this, new Vector2(100, 100));
            Level.LoadContent();

            base.LoadContent();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.RoyalBlue);
            SpriteBatch.Begin();
           
            Level.Draw(SpriteBatch);
            Megaman.Draw(SpriteBatch);

            SpriteBatch.End();

            base.Draw(gameTime);
        }

        protected override void Update(GameTime gameTime)
        {
            ControllerList[0].Update();
            Level.Update(Megaman);
            Megaman.Update();

            base.Update(gameTime);
        }
    }
}
