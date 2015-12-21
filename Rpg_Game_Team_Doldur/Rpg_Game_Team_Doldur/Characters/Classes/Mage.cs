using System;
using System.Drawing;

namespace Rpg_Game_Team_Doldur.Characters.Classes
{
    public class Mage : Player
    {
         private const int initialDamage = 20;
         private const int initialHealth = 150;
         private const int initialEnergyPoints = 350;
         private static Image img = Properties.Resources.Mage;
       
        public Mage(int id, Position position, string name)
             : base(id, position, initialDamage, initialHealth, name, initialEnergyPoints, img)
        {
           
        }

        public override void Heal()
        {
            throw new NotImplementedException();
        }
    }
}
