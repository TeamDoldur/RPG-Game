using System;
using System.Drawing;

namespace Rpg_Game_Team_Doldur.Characters.Classes
{
    public class Warrior : Player
    {
         private const int initialDamage = 50;
         private const int initialHealth = 250;
         private const int initialEnergyPoints = 100;
        private static Image img = Properties.Resources.BOV_Warrior;
       
        public Warrior(int id, Position position, string name)
             : base(id, position, initialDamage, initialHealth, name, initialEnergyPoints, img)
        {
           
        }

        public override void Heal()
        {
            throw new NotImplementedException();
        }
    }
}
