namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    partial class ChooseCharacterScreenForm
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
            this.anunakRadioButton = new System.Windows.Forms.RadioButton();
            this.booteanRadioButton = new System.Windows.Forms.RadioButton();
            this.terosRadioButton = new System.Windows.Forms.RadioButton();
            this.chooseCharacterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anunakRadioButton
            // 
            this.anunakRadioButton.AutoSize = true;
            this.anunakRadioButton.Location = new System.Drawing.Point(55, 88);
            this.anunakRadioButton.Name = "anunakRadioButton";
            this.anunakRadioButton.Size = new System.Drawing.Size(62, 17);
            this.anunakRadioButton.TabIndex = 0;
            this.anunakRadioButton.TabStop = true;
            this.anunakRadioButton.Text = "Anunak";
            this.anunakRadioButton.UseVisualStyleBackColor = true;
            // 
            // booteanRadioButton
            // 
            this.booteanRadioButton.AutoSize = true;
            this.booteanRadioButton.Location = new System.Drawing.Point(168, 88);
            this.booteanRadioButton.Name = "booteanRadioButton";
            this.booteanRadioButton.Size = new System.Drawing.Size(65, 17);
            this.booteanRadioButton.TabIndex = 1;
            this.booteanRadioButton.TabStop = true;
            this.booteanRadioButton.Text = "Bootean";
            this.booteanRadioButton.UseVisualStyleBackColor = true;
            // 
            // terosRadioButton
            // 
            this.terosRadioButton.AutoSize = true;
            this.terosRadioButton.Location = new System.Drawing.Point(283, 88);
            this.terosRadioButton.Name = "terosRadioButton";
            this.terosRadioButton.Size = new System.Drawing.Size(52, 17);
            this.terosRadioButton.TabIndex = 2;
            this.terosRadioButton.TabStop = true;
            this.terosRadioButton.Text = "Teros";
            this.terosRadioButton.UseVisualStyleBackColor = true;
            // 
            // chooseCharacterButton
            // 
            this.chooseCharacterButton.Location = new System.Drawing.Point(158, 176);
            this.chooseCharacterButton.Name = "chooseCharacterButton";
            this.chooseCharacterButton.Size = new System.Drawing.Size(75, 39);
            this.chooseCharacterButton.TabIndex = 3;
            this.chooseCharacterButton.Text = "Choose character";
            this.chooseCharacterButton.UseVisualStyleBackColor = true;
            this.chooseCharacterButton.Click += new System.EventHandler(this.chooseCharacterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the race of your character";
            // 
            // ChooseCharacterScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseCharacterButton);
            this.Controls.Add(this.terosRadioButton);
            this.Controls.Add(this.booteanRadioButton);
            this.Controls.Add(this.anunakRadioButton);
            this.Name = "ChooseCharacterScreenForm";
            this.Text = "ChooseCharacterScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton anunakRadioButton;
        private System.Windows.Forms.RadioButton booteanRadioButton;
        private System.Windows.Forms.Button chooseCharacterButton;
        private System.Windows.Forms.RadioButton terosRadioButton;
        private System.Windows.Forms.Label label1;
    }
}