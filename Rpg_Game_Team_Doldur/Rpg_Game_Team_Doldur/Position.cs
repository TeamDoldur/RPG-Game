using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur
{
    public struct Position
    {
        private int x;
        private int y;

        public Position(int x, int y)
            :this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get { return this.x; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("x", "X coordinate must not be less than 0.");
                }

                this.x = value;
            }
        }

        public int Y
        {
            get { return this.y; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("y", "Y coordinate must not be less than 0.");
                }

                this.y = value;
            }
        }
    }
}
