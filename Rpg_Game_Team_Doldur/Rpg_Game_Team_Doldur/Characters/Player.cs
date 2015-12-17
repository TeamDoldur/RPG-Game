using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Rpg_Game_Team_Doldur.Interfaces;
using Rpg_Game_Team_Doldur.Properties;

namespace Rpg_Game_Team_Doldur.Characters
{
    public abstract class Player : Character, IHeal, IPlayer
    {
        private string name;
        private int energyPoints;
        private const int movingStepX = 10;
        private const int movingStepY = 10;
        protected Player(int id, Position position, string name, int damage, int health, int energyPoints, PlayerClass playerClass)
            :base(id, position, damage, health)
        {
            this.Class = playerClass;
            this.Name = name;
            this.EnergyPoints = energyPoints;
            VisualizePlayer();
        }


        private void VisualizePlayer()
        {
            this.Sprite = new PictureBox();
            this.Sprite.Image = Resources.BOV_Warrior;
            this.Sprite.BackColor = Color.Transparent;
            this.Sprite.Width = 40;
            this.Sprite.Height = 40;
            this.Sprite.Show();
            this.Sprite.Location = new Point(40, 0);
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
        public PictureBox Sprite { get; set; }

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

        public PlayerClass Class { get; private set; }

        public IEnumerable<GameObject> Items
        {
            get { throw new NotImplementedException(); }
        }

        public void Move(int x, int y)
        {
            Point currLoc = new Point(this.Sprite.Location.X, this.Sprite.Location.Y);
            this.Sprite.Location = new Point(currLoc.X + x, currLoc.Y + y);
           
        }

        public void CollectItem(GameObject item)
        {
            throw new NotImplementedException();
        }

        public abstract void Heal();
    }
}
