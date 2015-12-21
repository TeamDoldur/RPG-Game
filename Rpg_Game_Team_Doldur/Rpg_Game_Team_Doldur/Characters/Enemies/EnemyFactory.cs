using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    class EnemyFactory
    {
        public EnemyFactory(string enemyType, int id, Position position)
        {
            this.Enemy = CreateEnemy(enemyType, id, position);
        }

        public Enemy Enemy { get; private set; }

        private Enemy CreateEnemy(string type, int id, Position position)
        {
            switch (type)
            {
                case "Bandit":
                    return new Bandit(id,position);
                    break;
                default:
                    return null;
            }
        }

    }
}
