using MegaManGame.CollisionDetection;
using MegaManGame.CollisionHandlers;
using MegaManGame.Interfaces;
using System;
using System.Collections.Generic;

namespace MegaManGame.CollisionManager
{
    class CollisionManager:ICollisionManager
    {
        private ICollisionDetector myCollisionDetector;
        private ICollision theCollision;

        private PlayerBlockCollisionHandler playerBlockHandler;
        private PlayerItemCollisionHandler playerItemHandler;
        private PlayerEnemyCollisionHandler playerEnemyHandler;
        public CollisionManager()
        {
            myCollisionDetector = new CollisionDetector();
            playerBlockHandler = new PlayerBlockCollisionHandler();
            playerItemHandler = new PlayerItemCollisionHandler();
            playerEnemyHandler = new PlayerEnemyCollisionHandler();
        }
        public void Update(IPlayer player, List<IBlock> blockList, List<IEnemy> enemiesList, List<IItem> itemsList)
        {
          
            foreach(IBlock block in blockList)
            {
                if (myCollisionDetector.IsColliding(player.GetRectangle(), block.GetRectangle()))
                {
                    theCollision = myCollisionDetector.CreateCollision(player.GetRectangle(), block.GetRectangle());
                    playerBlockHandler.HandleCollision(player, block, theCollision);
                }
            }

            foreach(IItem item in itemsList)
            {
                if (myCollisionDetector.IsColliding(player.GetRectangle(), item.GetRectangle()))
                {
                    theCollision = myCollisionDetector.CreateCollision(player.GetRectangle(), item.GetRectangle());
                    playerItemHandler.HandleCollision(player, item, theCollision);
                }
            }

            foreach(IEnemy enemy in enemiesList)
            {
                if (myCollisionDetector.IsColliding(player.GetRectangle(), enemy.GetRectangle()))
                {
                    theCollision = myCollisionDetector.CreateCollision(player.GetRectangle(), enemy.GetRectangle());
                    playerEnemyHandler.HandleCollision(player, enemy, theCollision);
                }
            }
        }
    }
}
