using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Characters.Enemies;
using Rpg_Game_Team_Doldur.Dependencies;

namespace Rpg_Game_Team_Doldur.Engines
{
    public class EnemyHandler
    {
        private IList<Enemy> enemyList;
        public EnemyHandler()
        {
            this.enemyList = new List<Enemy>();
           
        }

        public IEnumerable<Enemy> EnemyList
        {
            get { return this.enemyList; }
        }
        public void LoadEnemies(string map)
        {
            this.enemyList = new List<Enemy>();
            StreamReader reader = new StreamReader(@"..\..\Resources\Maps\ShadowMountains\EnemiesLocation\" + map + ".txt");
            string[] enemySprites = new string[2];
            enemySprites[0] = "None";
            enemySprites[1] = "Bandit";

            int y = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();


                for (int x = 0; x < line.Length; x++)
                {
                    int lineX = line[x] - '0';
                    Enemy enemy = new EnemyFactory(enemySprites[lineX],1,new Position(x*40,y*40)).Enemy;
                    if(enemy != null)
                    { 
                        this.enemyList.Add(enemy);
                    }
                }

                y++;
            }

            reader.Close();
        }
     }
 }

