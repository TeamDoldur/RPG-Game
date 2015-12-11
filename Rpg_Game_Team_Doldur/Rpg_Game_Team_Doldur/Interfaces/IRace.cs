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
        double InitialDamage { get; }

        //Different for each race
        int InitialEnergy { get; }

        //Calculated by race and age
        int InitialHealth { get; }

        //Different for each race
        int MaxSkillsCanHold { get; }

        //Different for each race
        IList<ISkill> Skills { get; }
    }
}
