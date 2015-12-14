using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Rpg_Game_Team_Doldur.Interfaces;

namespace Rpg_Game_Team_Doldur.Characters
{
    public abstract class Player : Character, IPlayer
    {
        protected Player(int id, Position position, int damage, int health, PlayerRace race)
            :base(id, position, damage, health)
        {
            this.Race = race;
        }

        public PlayerRace Race { get; private set; }

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
