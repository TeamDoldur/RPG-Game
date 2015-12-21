using System;
using System.Drawing;

namespace Rpg_Game_Team_Doldur.Characters.PlayerCharacters
{
    public class Warrior : Player
    {
        private const int InitialDamage = 50;
        private const int InitialHealth = 250;
        private const int InitialEnergyPoints = 100;
        private static readonly Image Img = Properties.Resources.BOV_Warrior;

        public Warrior(Position position, string name)
            : base(position, InitialHealth, InitialDamage, name, InitialEnergyPoints, Img)
        {

        }

        public override void Heal()
        {
            throw new NotImplementedException();
        }
    }
}
