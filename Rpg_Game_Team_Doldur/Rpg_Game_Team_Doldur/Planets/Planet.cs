using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heroes;

namespace Planets
{
    public partial class Planet : Form
    {
        public Planet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = new Player("ad", Common.Race.Anunak, Common.Gender.Female, 22);

            label1.Text = player.Health.ToString();
        }
    }
}
