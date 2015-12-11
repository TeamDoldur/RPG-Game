using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Common;

namespace Interfaces
{
    public interface IHumanoid
    {
        string Name { get; }

        Gender Gender { get; }

        int Age { get; }
    }
}
