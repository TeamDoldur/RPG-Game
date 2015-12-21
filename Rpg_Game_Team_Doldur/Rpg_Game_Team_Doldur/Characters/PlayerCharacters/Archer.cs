using System;
using System.Drawing;

namespace Rpg_Game_Team_Doldur.Characters.Classes
{
    public class Archer : Player
    {
         private const int initialDamage = 305;
         private const int initialHealth = 220;
         private const int initialEnergyPoints = 130;
         private static Image img = Properties.Resources.Archer;

         public Archer(int id, Position position, string name)
             : base(id, position, initialDamage, initialHealth, name, initialEnergyPoints, img)
        {
           
        }

        public override void Heal()
        {
            throw new NotImplementedException();
        }
    }
}
