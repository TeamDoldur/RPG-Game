using System.Collections;
using System.Collections.Generic;

namespace Rpg_Game_Team_Doldur.Interfaces
{
    public interface ICollision
    {
        IEnumerable<ICharacter> UnitsInMap { get; }
        void DetectCollision(ICharacter player, ICharacter enemy);
    }
}