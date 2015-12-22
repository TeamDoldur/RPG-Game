using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Interfaces;
using Rpg_Game_Team_Doldur.Properties;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    public class Gargoyle : Enemy
    {
        private const int GargoyleDamage = 30;
        private const int GargoyleHealth = 200;
        private static readonly Image Img = Properties.Resources.Gargoyle;

        public Gargoyle(Position position)
            : base(position, GargoyleHealth, GargoyleDamage, Img)
        {
        }
    }
}