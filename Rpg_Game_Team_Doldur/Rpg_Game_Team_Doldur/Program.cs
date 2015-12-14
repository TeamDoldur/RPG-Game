using System;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Engines.Screens;

namespace Rpg_Game_Team_Doldur
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }
    }
}
