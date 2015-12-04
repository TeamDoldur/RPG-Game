using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG_Game
{
    public partial class CombatGUI : Form
    {
        List<CombatPartyMember> playerPartyMembers;
        CombatPartyMember enemyMember;
        int currentPartyMember = 0;
        public bool inCombat;
        //
        public bool playerTurn;
        private Timer enemyAttackTimer;
        private IContainer components;
        private Label PartyPB1;
        private Label PartyPB2;
        private Label EnemyPB1;
        private CheckBox partyActionAttack;
        private CheckBox partyActionSkill;
        private CheckBox checkBox3;
        private Button btnAttack;
        private ComboBox cmbSkill;
        private TextBox flavourTextBox;
        List<ActiveSkill> activeSkills = new List<ActiveSkill>();

        public CombatGUI()
        {
            InitializeComponent();
            playerPartyMembers = new List<CombatPartyMember>();

            inCombat = false;
            //
            playerTurn = true;
            enemyAttackTimer.Interval = 1000;
        }


        //
        public void StartCombat(PlayerParty playerParty, CombatPartyMember enemy)
        {
            enemyMember = enemy;
            playerPartyMembers.Add(playerParty.member1);
            playerPartyMembers.Add(playerParty.member2);
            inCombat = true;

            PartyPB1.Image = playerPartyMembers[0].img;
            PartyPB2.Image = playerPartyMembers[0].img;
            EnemyPB1.Image = enemyMember.img;
            LoadSkillsForPlayer();
        }

        void OutputFlavourText(string text)
        {
            flavourTextBox.AppendText("\n" + text);
        }

        void LoadSkillsForPlayer()
        {
            cmbSkill.Items.Clear();

            foreach (Skill s in playerPartyMembers[currentPartyMember].skills)
            {
                cmbSkill.Items.Add(s.name);
            }
        }

        void ApplySkillDamage()
        {
            for (int x = 0; x < activeSkills.Count; x++)
            {
                var a = activeSkills[x];
                a.target.health -= a.skill.damagePerTurn;
                a.remainingTurns--;

                OutputFlavourText(a.skill.name + " did " + a.skill.damagePerTurn + " damage!");

                if (a.remainingTurns == 0)
                    activeSkills.RemoveAt(x);
            }
        }

     

        private void enemyAttackTimer_Tick(object sender, EventArgs e)
        {
            //Target a random player
            Random rand = new Random();
            int x = rand.Next(0, playerPartyMembers.Count);
            //Damage player
            playerPartyMembers[x].health -= enemyMember.attackPower;
            OutputFlavourText("Player + " + playerPartyMembers[x].name + " hit for " + enemyMember.attackPower + " damage!");

            //Check if all players are still alive
            inCombat = false;
            foreach (CombatPartyMember c in playerPartyMembers)
            {
                if (c.health >= 0)
                {
                    inCombat = true;
                }
            }

            enemyAttackTimer.Enabled = false;

            if (inCombat == false)
            {
                OutputFlavourText("Player party defeated!");
                //do something
            }
            else
            {
                playerTurn = true;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.enemyAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.PartyPB1 = new System.Windows.Forms.Label();
            this.PartyPB2 = new System.Windows.Forms.Label();
            this.EnemyPB1 = new System.Windows.Forms.Label();
            this.partyActionAttack = new System.Windows.Forms.CheckBox();
            this.partyActionSkill = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.flavourTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enemyAttackTimer
            // 
            this.enemyAttackTimer.Enabled = true;
            // 
            // PartyPB1
            // 
            this.PartyPB1.AutoSize = true;
            this.PartyPB1.Location = new System.Drawing.Point(12, 27);
            this.PartyPB1.Name = "PartyPB1";
            this.PartyPB1.Size = new System.Drawing.Size(35, 13);
            this.PartyPB1.TabIndex = 1;
            this.PartyPB1.Text = "label1";
            // 
            // PartyPB2
            // 
            this.PartyPB2.AutoSize = true;
            this.PartyPB2.Location = new System.Drawing.Point(12, 57);
            this.PartyPB2.Name = "PartyPB2";
            this.PartyPB2.Size = new System.Drawing.Size(35, 13);
            this.PartyPB2.TabIndex = 2;
            this.PartyPB2.Text = "label1";
            // 
            // EnemyPB1
            // 
            this.EnemyPB1.AutoSize = true;
            this.EnemyPB1.Location = new System.Drawing.Point(194, 27);
            this.EnemyPB1.Name = "EnemyPB1";
            this.EnemyPB1.Size = new System.Drawing.Size(35, 13);
            this.EnemyPB1.TabIndex = 3;
            this.EnemyPB1.Text = "label1";
            // 
            // partyActionAttack
            // 
            this.partyActionAttack.AutoSize = true;
            this.partyActionAttack.Location = new System.Drawing.Point(15, 136);
            this.partyActionAttack.Name = "partyActionAttack";
            this.partyActionAttack.Size = new System.Drawing.Size(80, 17);
            this.partyActionAttack.TabIndex = 5;
            this.partyActionAttack.Text = "checkBox1";
            this.partyActionAttack.UseVisualStyleBackColor = true;
            // 
            // partyActionSkill
            // 
            this.partyActionSkill.AutoSize = true;
            this.partyActionSkill.Location = new System.Drawing.Point(15, 159);
            this.partyActionSkill.Name = "partyActionSkill";
            this.partyActionSkill.Size = new System.Drawing.Size(80, 17);
            this.partyActionSkill.TabIndex = 6;
            this.partyActionSkill.Text = "checkBox2";
            this.partyActionSkill.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 182);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(249, 217);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "button1";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // cmbSkill
            // 
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Location = new System.Drawing.Point(10, 255);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(121, 21);
            this.cmbSkill.TabIndex = 9;
            // 
            // flavourTextBox
            // 
            this.flavourTextBox.Location = new System.Drawing.Point(137, 255);
            this.flavourTextBox.Multiline = true;
            this.flavourTextBox.Name = "flavourTextBox";
            this.flavourTextBox.Size = new System.Drawing.Size(284, 75);
            this.flavourTextBox.TabIndex = 0;
            // 
            // CombatGUI
            // 
            this.ClientSize = new System.Drawing.Size(618, 470);
            this.Controls.Add(this.cmbSkill);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.partyActionSkill);
            this.Controls.Add(this.partyActionAttack);
            this.Controls.Add(this.EnemyPB1);
            this.Controls.Add(this.PartyPB2);
            this.Controls.Add(this.PartyPB1);
            this.Controls.Add(this.flavourTextBox);
            this.Name = "CombatGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            ApplySkillDamage();

            if (inCombat)
            {
                //
                if (playerTurn)
                {
                    LoadSkillsForPlayer();

                    if (partyActionAttack.Checked)
                    {
                        //Damage done will vary
                        int damage = playerPartyMembers[currentPartyMember].attackPower;

                        OutputFlavourText(playerPartyMembers[currentPartyMember].name + " attacked foe for " + damage);

                        enemyMember.health -= damage;
                    }

                    if (partyActionSkill.Checked)
                    {
                        //get skill which matches skill in box
                        foreach (Skill s in playerPartyMembers[currentPartyMember].skills)
                        {
                            if (s.name == cmbSkill.Text)
                            {
                                ActiveSkill a = new ActiveSkill();
                                a.skill = s;
                                a.target = enemyMember;
                                a.remainingTurns = s.duration;
                                activeSkills.Add(a);

                                enemyMember.health -= s.initialDamage;
                                OutputFlavourText(playerPartyMembers[currentPartyMember].name + " cast " + s.name + " for " + s.initialDamage);
                            }
                        }
                    }
                    //
                    if (currentPartyMember < playerPartyMembers.Count)
                    {
                        currentPartyMember++;
                    }
                    else
                    {
                        currentPartyMember = 0;
                        playerTurn = false;
                        enemyAttackTimer.Enabled = true;
                    }
                }

                //Exit battle if enemy is dead
                if (enemyMember.health <= 0)
                {
                    flavourTextBox.AppendText("\n" + "Enemy defeated!");
                    inCombat = false;

                }
            }
        }
    }

    public class CombatPartyMember
    {
        //
        public string name;

        public int health;
        public int attackPower;
        public Image img;
        public List<Skill> skills = new List<Skill>();

        //
        public CombatPartyMember(int health, int attackPower, Image img, string name)
        {
            this.health = health;
            this.attackPower = attackPower;
            this.img = img;
            this.name = name;

            //
            Skill s = new Skill();
            s.damagePerTurn = 2;
            s.initialDamage = 3;
            s.duration = 1;
            s.name = "Bleed";
            skills.Add(s);
        }
    }

    //
    public class Skill
    {
        public int initialDamage;
        public int damagePerTurn;
        public int duration;
        public string name;
    }

    //
    public class ActiveSkill
    {
        public Skill skill;
        public CombatPartyMember target;
        public int remainingTurns;
    }
}