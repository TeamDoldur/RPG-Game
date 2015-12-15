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
    public partial class ChooseCharacterScreen : Form
    {
        public ChooseCharacterScreen()
        {
            InitializeComponent();
        }
        
        private void chooseCharacterButton_Click(object sender, EventArgs e)
        {
            if (this.anunakRadioButton.Checked)
            {
                
            }
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
