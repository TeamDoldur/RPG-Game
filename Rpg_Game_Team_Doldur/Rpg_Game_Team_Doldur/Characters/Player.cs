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
            this.VisualizePlayer(position.X, position.Y);
        }

        public override void VisualizePlayer(int posX, int posY)
        {
            base.SpritePictureBox = new PictureBox();
            base.SpritePictureBox.Image = Resources.BOV_Warrior;
            base.SpritePictureBox.BackColor = Color.Transparent;
            base.SpritePictureBox.Width = 40;
            base.SpritePictureBox.Height = 40;
            base.SpritePictureBox.Show();
            base.SpritePictureBox.Location = new Point(posX, posY);
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
            base.Position = new Position(currLoc.X + x, currLoc.Y + y);
           
        }

        public void CollectItem(GameObject item)
        {
            throw new NotImplementedException();
        }

        public abstract void Heal();
    }
}
