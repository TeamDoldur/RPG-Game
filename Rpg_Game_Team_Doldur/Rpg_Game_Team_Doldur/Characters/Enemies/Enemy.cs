using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    public abstract class Enemy : Character
    {
        protected Enemy(int id, Position position, int damage, int health)
            : base(id, position, damage, health)
        {

        }

        public override void VisualizePlayer(int posX, int posY)
        {
            
        }
    }
}
