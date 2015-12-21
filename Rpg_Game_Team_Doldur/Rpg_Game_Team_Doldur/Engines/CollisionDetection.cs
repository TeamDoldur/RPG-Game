using System.Collections;
using Rpg_Game_Team_Doldur.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Characters;
using Rpg_Game_Team_Doldur.Characters.Enemies;

namespace Rpg_Game_Team_Doldur.Engines
{
    public class CollisionDetection : ICollision
    {
        public CollisionDetection(Form level, Form combatForm)
        {
            this.Form = level;
            this.CombatForm = combatForm;
        }

        private Form Form { get; set; }
        private Form CombatForm {get; set; }
        public IEnumerable<ICharacter> UnitsInMap { get; private set; }
        public void DetectCollision(ICharacter player, ICharacter enemy)
        {
            if ((player.Position.X == enemy.Position.X) && (player.Position.Y == enemy.Position.Y))
            {
                this.Form.Hide();
                this.CombatForm.StartPosition = FormStartPosition.Manual;
                CombatForm.Location = this.Form.Location;
                CombatForm.Show();
                CombatForm.Activate();
            }
        }
    }
}