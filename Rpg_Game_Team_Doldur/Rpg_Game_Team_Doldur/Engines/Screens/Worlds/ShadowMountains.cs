﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Characters;
using Rpg_Game_Team_Doldur.Characters.Classes;
using Rpg_Game_Team_Doldur.Common;
using Rpg_Game_Team_Doldur.Dependencies;


namespace Rpg_Game_Team_Doldur.Engines.Screens.Worlds
{
    public partial class ShadowMountains : Form
    {
        private Player player;
        private Graphics graphics;
        private int mapX;
        private int mapY;
        public Image mapImage;
        public List<Tile> mapTiles;
        PictureBox worldMapSpritePb;
        private bool inCombat;
        private TextBoxReader textBoxReader;


        public ShadowMountains(Player player)
        {
            InitializeComponent();
            this.Player = player;
            mapTiles = new List<Tile>();
            InitializeLevel();
            Draw();
        }


        public Player Player { get; private set; }


        public void InitializeLevel()
        {
            LoadNewMap(0, 0);

            inCombat = false;

            textBoxReader = new TextBoxReader();

            worldMapSpritePb = new PictureBox();
            worldMapSpritePb.Width = this.Width;
            worldMapSpritePb.Height = this.Height;
            worldMapSpritePb.BackColor = Color.Transparent;
            worldMapSpritePb.Parent = this;
            worldMapSpritePb.BorderStyle = BorderStyle.None;
            this.Controls.Add(this.Player.Sprite);
            this.Player.Sprite.Parent = this.worldMapSpritePb;

        }

        void LoadNewMap(int xMove, int yMove)
        {
            mapX += xMove;
            mapY += yMove;
            this.LoadMap(mapX + " " + mapY);

            // LoadMonstersOnMap();
            //LoadFriendlyNPCsOnMap();
        }


        public void LoadMap(string mapName)
        {
            mapTiles.Clear();
            StreamReader reader = new StreamReader(@"MapTileData\" + mapName + ".txt");

            int y = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();


                for (int x = 0; x < line.Length; x++)
                {
                    Tile t = new Tile();

                    t.loc = new Point(x * 40, y * 40);

                    if (line[x].ToString() == "1")
                    {

                        t.img = Properties.Resources.GrassTile;
                        t.walkable = true;
                    }
                    if (line[x].ToString() == "0")
                    {
                        t.img = Properties.Resources.WaterTile;
                        t.walkable = false;
                    }

                    mapTiles.Add(t);
                }

                y++;
            }

            reader.Close();
        }


        void Draw()
        {
            Graphics device;
            Image img = new Bitmap(this.Width, this.Height);
            device = Graphics.FromImage(img);

            this.DrawMap(device);
            // playerParty.partySprite.Draw(device);

            //foreach (WorldMapMonster m in worldMapMonsters)
            //{
            //    //check if monster is alive before drawing
            //    if (m.alive)
            //        m.Draw(device);
            //}

            //
            //foreach (WorldMapSprite m in friendlyNPCs)
            //{
            //    m.Draw(device);
            //}

            if (textBoxReader.open)
            {
                device.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 300, this.Height, this.Width));
                device.DrawString(textBoxReader.currentText, new Font("arial", 10),
                    new SolidBrush(Color.White), new Point(5, 305));
            }

            worldMapSpritePb.Image = img;
        }

        public void DrawMap(Graphics device)
        {
            foreach (Tile t in mapTiles)
            {
                device.DrawImageUnscaledAndClipped(t.img, new Rectangle(t.loc, new Size(40, 40)));
                //device.DrawImage(t.img, t.loc);
            }
        }

        public bool GetWalkableAt(Point loc)
        {
            foreach (Tile t in mapTiles)
            {
                if (t.loc == loc)
                {
                    if (t.walkable)
                        return true;
                }
            }

            return false;
        }


      

        private void ShadowMountains_KeyDown(object sender, KeyEventArgs e)
        {

            if (!inCombat)
            {
                Point p = new Point(0, 0);

                if (e.KeyCode == Keys.Left)
                {
                    p = new Point(-40, 0);
                }
                if (e.KeyCode == Keys.Right)
                {
                    p = new Point(40, 0);
                }
                if (e.KeyCode == Keys.Up)
                {
                    p = new Point(0, -40);
                }
                if (e.KeyCode == Keys.Down)
                {
                    p = new Point(0, 40);
                }

                //
                Point potentialMove = new Point(p.X + this.Player.Sprite.Location.X,
                    p.Y + this.Player.Sprite.Location.Y);


                if (this.GetWalkableAt(potentialMove))
                {
                    this.Player.Move(p.X, p.Y);
                }
                else
                {
                    //Load new map if possible
                    if (potentialMove.X > this.Width-80)
                    {
                        LoadNewMap(1, 0);
                        this.Player.Move((this.Width * (-1)), 0);
                    }
                    if (potentialMove.X < 0)
                    {
                        this.Player.Move(0, 0);
                    }
                    if (potentialMove.Y < 0)
                    {
                        this.Player.Move(0, 0);
                    }
                    if (potentialMove.Y > this.Height)
                    {
                        this.Player.Move(0, this.Height);
                    }
                }
            }
            else
            {
                //    //Use monsterInCombat variable to remove correct sprite
                //    //If the combat GUI has exited combat, remove our enemy sprite
                //    if (!combatGUI.inCombat)
                //    {
                //        monsterInCombat.alive = false;
                //        KillMonsterInList(monsterInCombat);
                //        inCombat = false;
                //    }
                //}

                //DetectCollision();
            }

            Draw();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
