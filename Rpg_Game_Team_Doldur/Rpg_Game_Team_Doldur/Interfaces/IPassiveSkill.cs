using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Rpg_Game_Team_Doldur.Interfaces
{
    interface IPassiveSkill : ISkill
    {
        int Duration { get; }
    }
}
