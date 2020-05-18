using MegaManGame.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Diagnostics;

namespace MegaManGame
{
    public class Level : ILevel
    {
        private List<IBlock> Blocks;
        private List<IEnemy> Enemies;
        private List<IItem> Items;
        private List<IBackground> Background;
        private LevelLoader GutsManLevel;
        private ICollisionManager CollisionManager;
        private IPlayer Player;

        public Level(string levelName, IPlayer player)
        {
            Blocks = new List<IBlock>();
            Enemies = new List<IEnemy>();
            Items = new List<IItem>();
            Background = new List<IBackground>();
            GutsManLevel = new LevelLoader(levelName);
            CollisionManager = new CollisionManager.CollisionManager();
            Player = player;
        }

        public void LoadContent()
        {
            GutsManLevel.LoadLevel(this); 
        }
        public void AddBlock(IBlock block)
        {
            Blocks.Add(block);
        }

        public void AddBackground(IBackground backgroundItem)
        {
            Background.Add(backgroundItem);
        }

        public void AddEnemy(IEnemy enemy)
        {
            Enemies.Add(enemy);
        }

        public void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // note background objects must be drawn first
            foreach (IBackground backItem in Background)
            {
                backItem.Draw(spriteBatch);
            }
            foreach (IBlock block in Blocks)
            {
                block.Draw(spriteBatch);
            }
            foreach (IItem item in Items)
            {
                item.Draw(spriteBatch);
            }
            foreach (IEnemy enemy in Enemies)
            {
                enemy.Draw(spriteBatch);
            }
        }

        public void Update(IPlayer player)
        {
            foreach (IEnemy enemy in Enemies)
            {
                enemy.Update();
            }
            foreach (IItem item in Items)
            {
                item.Update();
            }
            //Debug.WriteLine("Player Location: " + Player.locationtho());
            CollisionManager.Update(player, Blocks, Enemies, Items);
        }
    }
}
