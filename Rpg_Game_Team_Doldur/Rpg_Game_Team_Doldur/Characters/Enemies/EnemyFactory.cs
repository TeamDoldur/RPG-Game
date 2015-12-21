using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    public class EnemyFactory
    {
        public Enemy CreateEnemy(string type, Position position)
        {
            switch (type)
            {
                case "Bandit":
                    return new Bandit(position);
                    break;
                case "Gargoyle":
                    return new Gargoyle(position);
                    break;
                default:
                    return null; // TODO: need fixing if there is time
                    throw new ArgumentException("There is no such enemy type.");
            }
        }
    }
}
