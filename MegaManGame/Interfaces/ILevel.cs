using MegaManGame.Interfaces;
using Microsoft.Xna.Framework.Graphics;

namespace MegaManGame
{
    public interface ILevel
    {
        void LoadContent();
        void Draw(SpriteBatch spriteBatch);
        void Update(IPlayer player);
        void AddBlock(IBlock block);
        void AddItem(IItem item);
        void AddEnemy(IEnemy enemy);
        void AddBackground(IBackground backgroundItem);
    }
}
