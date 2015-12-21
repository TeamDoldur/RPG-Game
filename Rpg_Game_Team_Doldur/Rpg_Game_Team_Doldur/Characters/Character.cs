using System;
using System.Collections.Generic;
using System.Drawing;
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

        protected Character(int id, Position position, int damage, int health, Image image)
            : base(id)
        {
            this.Position = position;
            this.Damage = damage;
            this.Health = health;
            this.IsAlive = true;
            VisualizePlayer(Position.X,Position.Y,image);
        }

        public Position Position
        {
            get { return this.position; }
            set { this.position = value; }
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

        void VisualizePlayer(int posX, int posY, Image image)
        {
            this.SpritePictureBox = new PictureBox();
            this.SpritePictureBox.Image = image;
            this.SpritePictureBox.BackColor = Color.Transparent;
            this.SpritePictureBox.Width = 40;
            this.SpritePictureBox.Height = 40;
            this.SpritePictureBox.Show();
            this.SpritePictureBox.Location = new Point(posX, posY);
        }

        public bool IsAlive { get; private set; }

        public void Attack(ICharacter enemy)
        {
            throw new NotImplementedException();
        }
    }
}
