using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Interfaces;
using Rpg_Game_Team_Doldur.Properties;

namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    public class Bandit : Enemy
    {
        private const int damage = 10;
        private const int health = 150;


        public Bandit(int id, Position position)
            : base(id, position, damage, health)
        {
            VisualizePlayer(position.X, position.Y);
        }

        public override void VisualizePlayer(int posX, int posY)
        {
            base.SpritePictureBox = new PictureBox();
            base.SpritePictureBox.Image = Resources.Bandits;
            base.SpritePictureBox.BackColor = Color.Transparent;
            base.SpritePictureBox.Width = 40;
            base.SpritePictureBox.Height = 40;
            base.SpritePictureBox.Show();
            base.SpritePictureBox.Location = new Point(posX, posY);
        }
    }
}