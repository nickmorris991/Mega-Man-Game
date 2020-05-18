using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
namespace MegaManGame
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> ControllerMappings;
        public KeyboardController()
        {
            ControllerMappings = new Dictionary<Keys, ICommand>();
        }
        public void RegisterCommand(int key, ICommand command)
        {
            ControllerMappings.Add((Keys)key, command);
        }
        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            if (((pressedKeys.Length == 1) && pressedKeys[0] == Keys.A) || pressedKeys.Length == 0)
            {
                ControllerMappings[Keys.Kanji].Execute();
            }
            foreach (Keys key in pressedKeys)
            {
                if (ControllerMappings.ContainsKey(key))
                {
                    ControllerMappings[key].Execute();
                }
            }
        }
    }
}
