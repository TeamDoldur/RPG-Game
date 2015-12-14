using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur
{
    public abstract class GameObject
    {
        private int id;

        protected GameObject(int id)
        {
            this.Id = id;
        }

        public int Id
        {
            get { return this.id; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id must be non-negative number", "id");
                }

                this.id = value;
            }
        }
    }
}
