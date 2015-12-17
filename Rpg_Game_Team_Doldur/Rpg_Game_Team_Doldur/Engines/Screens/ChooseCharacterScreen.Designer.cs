using System.Drawing;
using System.Windows.Forms;

namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    partial class ChooseCharacterScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.warriorRadioButton = new System.Windows.Forms.RadioButton();
            this.archerRadioButton = new System.Windows.Forms.RadioButton();
            this.mageRadioButton = new System.Windows.Forms.RadioButton();
            this.chooseCharacterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backToStartScreenButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warriorRadioButton
            // 
            this.warriorRadioButton.AutoSize = true;
            this.warriorRadioButton.Location = new System.Drawing.Point(55, 88);
            this.warriorRadioButton.Name = "warriorRadioButton";
            this.warriorRadioButton.Size = new System.Drawing.Size(59, 17);
            this.warriorRadioButton.TabIndex = 0;
            this.warriorRadioButton.TabStop = true;
            this.warriorRadioButton.Text = "Warrior";
            this.warriorRadioButton.UseVisualStyleBackColor = true;
            // 
            // archerRadioButton
            // 
            this.archerRadioButton.AutoSize = true;
            this.archerRadioButton.Location = new System.Drawing.Point(344, 88);
            this.archerRadioButton.Name = "archerRadioButton";
            this.archerRadioButton.Size = new System.Drawing.Size(56, 17);
            this.archerRadioButton.TabIndex = 1;
            this.archerRadioButton.TabStop = true;
            this.archerRadioButton.Text = "Archer";
            this.archerRadioButton.UseVisualStyleBackColor = true;
            // 
            // mageRadioButton
            // 
            this.mageRadioButton.AutoSize = true;
            this.mageRadioButton.Location = new System.Drawing.Point(594, 88);
            this.mageRadioButton.Name = "mageRadioButton";
            this.mageRadioButton.Size = new System.Drawing.Size(52, 17);
            this.mageRadioButton.TabIndex = 2;
            this.mageRadioButton.TabStop = true;
            this.mageRadioButton.Text = "Mage";
            this.mageRadioButton.UseVisualStyleBackColor = true;
            // 
            // chooseCharacterButton
            // 
            this.chooseCharacterButton.Location = new System.Drawing.Point(12, 475);
            this.chooseCharacterButton.Name = "chooseCharacterButton";
            this.chooseCharacterButton.Size = new System.Drawing.Size(250, 50);
            this.chooseCharacterButton.TabIndex = 3;
            this.chooseCharacterButton.Text = "Choose character";
            this.chooseCharacterButton.UseVisualStyleBackColor = true;
            this.chooseCharacterButton.Click += new System.EventHandler(this.chooseCharacterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the class of your character";
            // 
            // backToStartScreenButton
            // 
            this.backToStartScreenButton.Location = new System.Drawing.Point(572, 475);
            this.backToStartScreenButton.Name = "backToStartScreenButton";
            this.backToStartScreenButton.Size = new System.Drawing.Size(200, 50);
            this.backToStartScreenButton.TabIndex = 5;
            this.backToStartScreenButton.Text = "Back";
            this.backToStartScreenButton.UseVisualStyleBackColor = true;
            this.backToStartScreenButton.Click += new System.EventHandler(this.backToStartScreenButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(298, 475);
            this.nameInput.Multiline = true;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(230, 35);
            this.nameInput.TabIndex = 6;
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNameLabel.Location = new System.Drawing.Point(303, 432);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(217, 24);
            this.enterNameLabel.TabIndex = 7;
            this.enterNameLabel.Text = "Enter Character Name";
            // 
            // ChooseCharacterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.backToStartScreenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseCharacterButton);
            this.Controls.Add(this.mageRadioButton);
            this.Controls.Add(this.archerRadioButton);
            this.Controls.Add(this.warriorRadioButton);
            this.Name = "ChooseCharacterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseCharacterScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton warriorRadioButton;
        private System.Windows.Forms.RadioButton archerRadioButton;
        private System.Windows.Forms.Button chooseCharacterButton;
        private System.Windows.Forms.RadioButton mageRadioButton;
        private System.Windows.Forms.Label label1;
        private Button backToStartScreenButton;
        private TextBox nameInput;
        private Label enterNameLabel;
    }
}