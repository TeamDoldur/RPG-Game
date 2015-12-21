using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Characters;
using Rpg_Game_Team_Doldur.Characters.Classes;
using Rpg_Game_Team_Doldur.Engines.Screens.Worlds;

namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    public partial class ChooseCharacterScreen : Form
    {
        public ChooseCharacterScreen()
        {
            InitializeComponent();
        }
        
        private void chooseCharacterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameInput.Text))
            {
                Label erroLabel = new Label();
                erroLabel.Text = "You must enter character name before you press \"Choose character\" button";
                erroLabel.Enabled = true;
                erroLabel.Visible = true;
                var labelLocation = new Point(200,370);
                erroLabel.Font = new Font(FontFamily.GenericSerif, 10);
                erroLabel.Location = labelLocation;
                erroLabel.AutoSize = true;
                this.Controls.Add(erroLabel);
            }
            else
            {
                if (this.warriorRadioButton.Checked)
                {
                    Player player = new Warrior(1, new Position(10, 10), nameInput.Text);
                    CreatePlayerAndStartGame(player);
                   
                }

                else if (this.warriorRadioButton.Checked)
                {
                    Player player = new Warrior(1, new Position(10, 10), nameInput.Text);
                    CreatePlayerAndStartGame(player);
                }

                else if (this.warriorRadioButton.Checked)
                {
                    Player player = new Warrior(1, new Position(10, 10), nameInput.Text);
                    CreatePlayerAndStartGame(player);
                }
            }
        }

        private void CreatePlayerAndStartGame(Player player)
        {
            var firstLevel = new ShadowMountains(player);
            firstLevel.StartPosition = FormStartPosition.Manual;
            firstLevel.Location = this.Location;
            firstLevel.Show();
            firstLevel.Activate();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backToStartScreenButton_Click(object sender, EventArgs e)
        {
            Program.InitialScreen.Show();
            this.Hide();
        }
    }
}
