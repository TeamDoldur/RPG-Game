using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Common;


namespace Heroes
{
    public class Player : IRace
    {
       // private List<Skills> skills; 
        public Player(string name, Race race, Gender gender, int age)
        {
            this.Name = name;
            this.Race = race;
            this.Age = age;
           // this.skills = new List<Skills>();
            SetHealth(race, age);
        }

        public string Name { get; private set; }

        public Race Race { get; private set; }

        public Gender Gender { get; private set; }

        public int Age { get; private set; }

        public double Damage { get; private set; }

        public int Energy { get; private set; }
       
        private void SetHealth(Race race, int age)
        {
            int health = 0;
            switch (this.Race)
            {
              
                case Race.Anunak:
                    {
                        if (this.Age >= 20 && this.Age <= 30)
                        {
                            health = 260;
                        }
                        break;

                    }
            }

            this.Health = health;
        }
        public int Health { get; private set; }


        public int MaxSkillsCanHold { get; private set; }


        public IEnumerable<ISkill> Skills { get; private set; }

        public ILevel LevelInfo { get; private set; }
     
    }
}
