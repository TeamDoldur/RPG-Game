using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Rpg_Game_Team_Doldur.Interfaces
{
    public interface IPlayer : ICharacter, ICollect
    {
        PlayerClass Class { get; }
    }
}
