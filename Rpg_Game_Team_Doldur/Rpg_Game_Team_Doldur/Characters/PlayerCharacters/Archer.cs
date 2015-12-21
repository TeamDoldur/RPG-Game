using System;
using System.Drawing;

namespace Rpg_Game_Team_Doldur.Characters.PlayerCharacters
{
    public class Archer : Player
    {
         private const int InitialDamage = 305;
         private const int InitialHealth = 220;
         private const int InitialEnergyPoints = 130;
         private static readonly Image Img = Properties.Resources.Archer;

         public Archer(Position position, string name)
             : base(position, InitialHealth, InitialDamage, name, InitialEnergyPoints, Img)
        {
           
        }

        public override void Heal()
        {
            throw new NotImplementedException();
        }
    }
}
