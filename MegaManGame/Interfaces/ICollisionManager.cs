using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaManGame.Interfaces
{
    public interface ICollisionManager
    {
        void Update(IPlayer player, List<IBlock> blockList, List<IEnemy> enemiesList, List<IItem> itemsList);
    }
}
