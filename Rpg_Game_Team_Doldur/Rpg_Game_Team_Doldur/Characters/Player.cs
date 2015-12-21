namespace Rpg_Game_Team_Doldur.Characters
{
    using System;
    using System.Drawing;
    using Interfaces;

    public abstract class Player : Character, IHeal, IPlayer
    {
        private string name;
        private int energyPoints;

        protected Player(Position position, int health, int damage, string name, int energyPoints, Image image)
            : base(position, health, damage, image)
        {
            this.Name = name;
            this.EnergyPoints = energyPoints;
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

        public void Move(int x, int y)
        {
            Point currLoc = new Point(this.SpritePictureBox.Location.X, this.SpritePictureBox.Location.Y);
            this.SpritePictureBox.Location = new Point(currLoc.X + x, currLoc.Y + y);
            this.Position = new Position(currLoc.X + x, currLoc.Y + y);
        }

        public abstract void Heal();
    }
}
