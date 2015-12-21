namespace Rpg_Game_Team_Doldur.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Interfaces;
    using Properties;

    public abstract class Player : Character, IHeal, IPlayer
    {
        private const int MovingStepX = 10;
        private const int MovingStepY = 10;

        private string name;
        private int energyPoints;

        protected Player(int id, Position position, int damage, int health, string name, int energyPoints)
            :base(id, position, damage, health)
        {
            this.Name = name;
            this.EnergyPoints = energyPoints;
            this.VisualizePlayer();
        }

        private void VisualizePlayer()
        {
            this.SpritePictureBox = new PictureBox();
            this.SpritePictureBox.Image = Resources.BOV_Warrior;
            this.SpritePictureBox.BackColor = Color.Transparent;
            this.SpritePictureBox.Width = 40;
            this.SpritePictureBox.Height = 40;
            this.SpritePictureBox.Show();
            this.SpritePictureBox.Location = new Point(40, 0);
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Character name can`t be empty");
                }
                this.name = value;
            }
        }

        public PictureBox SpritePictureBox { get; set; }

        public int EnergyPoints
        {
            get { return this.energyPoints; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Energy points can`t be negative");
                }
                this.energyPoints = value;
            }
        }
        
        public IEnumerable<GameObject> Items
        {
            get { throw new NotImplementedException(); }
        }

        public void Move(int x, int y)
        {
            Point currLoc = new Point(this.SpritePictureBox.Location.X, this.SpritePictureBox.Location.Y);
            this.SpritePictureBox.Location = new Point(currLoc.X + x, currLoc.Y + y);
           
        }

        public void CollectItem(GameObject item)
        {
            throw new NotImplementedException();
        }

        public abstract void Heal();
    }
}
