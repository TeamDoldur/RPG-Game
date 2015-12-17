using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

            ChooseCharacterScreen = new ChooseCharacterScreen();
        }

        public ChooseCharacterScreen Type { get; set; }

        public ChooseCharacterScreen ChooseCharacterScreen { get; set; }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            ChooseCharacterScreen.Show();
            this.Hide();
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
