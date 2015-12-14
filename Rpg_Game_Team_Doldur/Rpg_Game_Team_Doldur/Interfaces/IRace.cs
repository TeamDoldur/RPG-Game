using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRace : IHumanoid
    {
        //Calculated by race and age
        double Damage { get; }

        //Different for each race
        int Energy { get; }

        //Calculated by race and age
        int Health { get; }

        //Different for each race
        int MaxSkillsCanHold { get; }

        //Different for each race
        IEnumerable<ISkill> Skills { get; }
    }
}
