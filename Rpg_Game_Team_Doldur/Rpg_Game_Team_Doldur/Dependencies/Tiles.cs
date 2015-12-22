using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur.Dependencies
{
    public struct Tile
    {
        public Image TileImg { get; set; }
        public Point TileLocation { get; set; }
        public bool Walkable { get; set; }
    }
}
