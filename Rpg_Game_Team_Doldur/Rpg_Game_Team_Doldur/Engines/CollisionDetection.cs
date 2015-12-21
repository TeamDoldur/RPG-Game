using System.Collections;
using Rpg_Game_Team_Doldur.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rpg_Game_Team_Doldur.Engines
{
    public class CollisionDetection : ICollision
    {

        public CollisionDetection()
        {
            this.UnitsInMap = new List<ICharacter>();
        }

        public IEnumerable<ICharacter> UnitsInMap { get; private set; }
        public void DetectCollision(ICharacter player, ICharacter enemy)
        {
            if ((player.Position.X == enemy.Position.X) && (player.Position.Y == enemy.Position.Y))
            {
                
            }
        }
    }
}