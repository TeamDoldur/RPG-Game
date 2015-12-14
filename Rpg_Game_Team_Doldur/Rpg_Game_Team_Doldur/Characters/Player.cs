using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Game_Team_Doldur.Interfaces;

namespace Rpg_Game_Team_Doldur.Characters
{
    public abstract class Player : Character, IPlayer
    {
        protected Player(int id)
            :base(id)
        {
            
        }

        public IEnumerable<GameObject> Items
        {
            get { throw new NotImplementedException(); }
        }

        public void CollectItem(GameObject item)
        {
            throw new NotImplementedException();
        }
    }
}
