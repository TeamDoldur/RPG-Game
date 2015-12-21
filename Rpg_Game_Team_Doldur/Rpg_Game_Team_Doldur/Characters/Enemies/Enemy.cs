using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    public abstract class Enemy : Character
    {
        protected Enemy(int id, Position position, int damage, int health, Image image)
            : base(id, position, damage, health, image)
        {

        }
    }
}
