using System;
using System.Drawing;
using Rpg_Game_Team_Doldur.Weapons;

namespace Rpg_Game_Team_Doldur.Characters.PlayerCharacters
{
    public class Archer : Player
    {
        private const int InitialDamage = 30;
        private const int InitialHealth = 220;
        private const int InitialEnergyPoints = 130;
        private const int HealingPoints = 60;
        private static readonly Image Img = Properties.Resources.Archer;

        public Archer(Position position, string name)
            : base(position, InitialHealth, InitialDamage, name, InitialEnergyPoints, Img, new Bow(), HealingPoints)
        {

        }
    }
}
