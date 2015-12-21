using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Interfaces;
using Rpg_Game_Team_Doldur.Properties;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    public class Bandit : Enemy
    {
        private const int damage = 10;
        private const int health = 150;
        private static Image img = Properties.Resources.Bandits;

        public Bandit(int id, Position position)
            : base(id, position, damage, health, img)
        {
           
        }

    }
}