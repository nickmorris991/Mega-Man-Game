using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MegaManGame
{
    class GamepadController : IController
    {
        private Dictionary<Buttons, ICommand> ControllerMappings;

        public GamepadController()
        {
            ControllerMappings = new Dictionary<Buttons, ICommand>();
        }
        public void RegisterCommand(int button, ICommand command)
        {
            ControllerMappings.Add((Buttons)button, command);
        }

        /*
         * GamePad doesn't seem to have a native GetPressedButtons method, so 
         * I implemented one.
         */
        private static List<Buttons> GetPressedButtons(GamePadState gamePadState)
        {
            List<Buttons> pressedButtons = new List<Buttons>();
            foreach (Buttons button in Enum.GetValues(typeof(Buttons)))
            {
                if (gamePadState.IsButtonDown(button))
                {
                    pressedButtons.Add(button);
                }
            }
            return pressedButtons;
        }
        public void Update()
        {
            GamePadState padState = GamePad.GetState(PlayerIndex.One);
            List<Buttons> pressedButtons = GetPressedButtons(padState);

            foreach (Buttons button in pressedButtons)
            {
                ControllerMappings[button].Execute();
            }
        }
    }
}
