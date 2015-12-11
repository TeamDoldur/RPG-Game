using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public interface ILevel
    {
        int CurrentLevel { get; set; }

        int PointsToNextLevel { get; }

        int CurrentXPpoints { get; }
    }
}
