using Rpg_Game_Team_Doldur.Interfaces;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    using System.Drawing;

    public abstract class Enemy : Character
    {
        protected Enemy(Position position, int health, int damage, Image image)
            : base(position, health, damage, image)
        {
        }

        public override void Attack(ICharacter enemy)
        {
            enemy.Health -= this.Damage;
        }
    }
}
