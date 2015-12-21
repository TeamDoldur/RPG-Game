using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Interfaces;

namespace Rpg_Game_Team_Doldur.Characters
{
    public abstract class Character : GameObject, ICharacter
    {
        private Position position;
        private int damage;
        private int health;

        protected Character(int id, Position position, int damage, int health)
            : base(id)
        {
            this.Position = position;
            this.Damage = damage;
            this.Health = health;
            this.IsAlive = true;
        }

        public Position Position
        {
            get { return this.position; }
            private set
            {
                if (value.X < 0 || value .Y < 0)
                {
                    throw new ArgumentOutOfRangeException("postion", "Position is out of range!");
                }

                this.position = value;
            }
        }

        public PictureBox SpritePictureBox { get; set; }
        public int Damage
        {
            get { return this.damage; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("damage", "Damage cannot be negative!");
                }

                this.damage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            private set
            {
                // validating health at its initialization
                if (this.health == 0)
                {
                    if (value <= 0)
                    {
                        throw new ArgumentOutOfRangeException("health", "Health cannot be non-positive!");
                    }

                    this.health = value;
                }
                else
                {
                    if (this.health <= 0)
                    {
                        this.IsAlive = false;
                    }
                }
            }
        }

        public abstract void VisualizePlayer(int posX, int posY);

        public bool IsAlive { get; private set; }

        public void Attack(ICharacter enemy)
        {
            throw new NotImplementedException();
        }
    }
}
