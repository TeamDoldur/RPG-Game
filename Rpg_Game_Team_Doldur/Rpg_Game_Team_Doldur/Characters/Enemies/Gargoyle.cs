using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Interfaces;
using Rpg_Game_Team_Doldur.Properties;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    public class Gargoyle : Enemy
    {
        private const int damage = 40;
        private const int health = 200;
        private static Image img = Properties.Resources.Gargoyle;

        public Gargoyle(int id, Position position)
            : base(id, position, damage, health, img)
        {
           
        }

    }
}