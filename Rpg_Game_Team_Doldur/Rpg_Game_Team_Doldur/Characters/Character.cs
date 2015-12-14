using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Game_Team_Doldur.Interfaces;

namespace Rpg_Game_Team_Doldur.Characters
{
    public abstract class Character : GameObject, ICharacter
    {
        protected Character(int id)
            : base(id)
        {
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public Position Position
        {
            get { throw new NotImplementedException(); }
        }

        public int Damage
        {
            get { throw new NotImplementedException(); }
        }

        public void Attack(ICharacter enemy)
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }

        public int Health
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsAlive
        {
            get { throw new NotImplementedException(); }
        }
    }
}
