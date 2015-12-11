using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Common;

namespace Interfaces
{
    interface IHumanoid
    {
        string Name { get; }

        Race Race { get; }

        Gender Gender { get; }

        int Age { get; }
    }
}
