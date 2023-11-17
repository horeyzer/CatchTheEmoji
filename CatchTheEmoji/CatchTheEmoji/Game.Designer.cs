namespace CatchTheEmoji
{
    partial class Game
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
            this.gameMod1 = new System.Windows.Forms.RadioButton();
            this.gameMod2 = new System.Windows.Forms.RadioButton();
            this.gameMod3 = new System.Windows.Forms.RadioButton();
            this.groupDifficulty1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit1 = new System.Windows.Forms.Button();
            this.labelWelcome1 = new System.Windows.Forms.Label();
            this.buttonStart1 = new System.Windows.Forms.Button();
            this.groupStatistics1 = new System.Windows.Forms.GroupBox();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.buttonLeaderboard1 = new System.Windows.Forms.Button();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.pictureBoxEmoji1 = new System.Windows.Forms.PictureBox();
            this.groupDifficulty1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupStatistics1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmoji1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameMod1
            // 
            this.gameMod1.AutoSize = true;
            this.gameMod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMod1.Location = new System.Drawing.Point(6, 19);
            this.gameMod1.Name = "gameMod1";
            this.gameMod1.Size = new System.Drawing.Size(84, 22);
            this.gameMod1.TabIndex = 0;
            this.gameMod1.TabStop = true;
            this.gameMod1.Tag = "1";
            this.gameMod1.Text = "Beginner";
            this.gameMod1.UseVisualStyleBackColor = true;
            this.gameMod1.CheckedChanged += new System.EventHandler(this.gameMod1_CheckedChanged);
            // 
            // gameMod2
            // 
            this.gameMod2.AutoSize = true;
            this.gameMod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMod2.Location = new System.Drawing.Point(6, 40);
            this.gameMod2.Name = "gameMod2";
            this.gameMod2.Size = new System.Drawing.Size(79, 22);
            this.gameMod2.TabIndex = 1;
            this.gameMod2.TabStop = true;
            this.gameMod2.Tag = "2";
            this.gameMod2.Text = "Average";
            this.gameMod2.UseVisualStyleBackColor = true;
            // 
            // gameMod3
            // 
            this.gameMod3.AutoSize = true;
            this.gameMod3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMod3.Location = new System.Drawing.Point(6, 61);
            this.gameMod3.Name = "gameMod3";
            this.gameMod3.Size = new System.Drawing.Size(90, 22);
            this.gameMod3.TabIndex = 2;
            this.gameMod3.TabStop = true;
            this.gameMod3.Tag = "3";
            this.gameMod3.Text = "Advanced";
            this.gameMod3.UseVisualStyleBackColor = true;
            // 
            // groupDifficulty1
            // 
            this.groupDifficulty1.Controls.Add(this.gameMod1);
            this.groupDifficulty1.Controls.Add(this.gameMod3);
            this.groupDifficulty1.Controls.Add(this.gameMod2);
            this.groupDifficulty1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDifficulty1.Location = new System.Drawing.Point(3, 196);
            this.groupDifficulty1.Name = "groupDifficulty1";
            this.groupDifficulty1.Size = new System.Drawing.Size(215, 93);
            this.groupDifficulty1.TabIndex = 3;
            this.groupDifficulty1.TabStop = false;
            this.groupDifficulty1.Text = "Difficulty";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.buttonExit1);
            this.panel1.Controls.Add(this.labelWelcome1);
            this.panel1.Controls.Add(this.buttonStart1);
            this.panel1.Controls.Add(this.groupStatistics1);
            this.panel1.Controls.Add(this.groupDifficulty1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 766);
            this.panel1.TabIndex = 4;
            // 
            // buttonExit1
            // 
            this.buttonExit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit1.Location = new System.Drawing.Point(63, 683);
            this.buttonExit1.Name = "buttonExit1";
            this.buttonExit1.Size = new System.Drawing.Size(85, 34);
            this.buttonExit1.TabIndex = 7;
            this.buttonExit1.Text = "Exit";
            this.buttonExit1.UseVisualStyleBackColor = true;
            this.buttonExit1.Click += new System.EventHandler(this.buttonExit1_Click);
            // 
            // labelWelcome1
            // 
            this.labelWelcome1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWelcome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome1.Location = new System.Drawing.Point(11, 9);
            this.labelWelcome1.Name = "labelWelcome1";
            this.labelWelcome1.Size = new System.Drawing.Size(201, 94);
            this.labelWelcome1.TabIndex = 5;
            this.labelWelcome1.Text = "Welcome, nickname";
            // 
            // buttonStart1
            // 
            this.buttonStart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart1.Location = new System.Drawing.Point(63, 106);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(85, 34);
            this.buttonStart1.TabIndex = 6;
            this.buttonStart1.Text = "Start";
            this.buttonStart1.UseVisualStyleBackColor = true;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click);
            // 
            // groupStatistics1
            // 
            this.groupStatistics1.Controls.Add(this.labelScore2);
            this.groupStatistics1.Controls.Add(this.labelTime2);
            this.groupStatistics1.Controls.Add(this.buttonLeaderboard1);
            this.groupStatistics1.Controls.Add(this.labelScore1);
            this.groupStatistics1.Controls.Add(this.labelTime1);
            this.groupStatistics1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStatistics1.Location = new System.Drawing.Point(3, 362);
            this.groupStatistics1.Name = "groupStatistics1";
            this.groupStatistics1.Size = new System.Drawing.Size(215, 234);
            this.groupStatistics1.TabIndex = 4;
            this.groupStatistics1.TabStop = false;
            this.groupStatistics1.Text = "Statistics";
            // 
            // labelScore2
            // 
            this.labelScore2.AutoSize = true;
            this.labelScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore2.Location = new System.Drawing.Point(60, 69);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(25, 25);
            this.labelScore2.TabIndex = 6;
            this.labelScore2.Text = "0";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime2.Location = new System.Drawing.Point(55, 30);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(25, 25);
            this.labelTime2.TabIndex = 5;
            this.labelTime2.Text = "0";
            // 
            // buttonLeaderboard1
            // 
            this.buttonLeaderboard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeaderboard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaderboard1.Location = new System.Drawing.Point(6, 200);
            this.buttonLeaderboard1.Name = "buttonLeaderboard1";
            this.buttonLeaderboard1.Size = new System.Drawing.Size(200, 28);
            this.buttonLeaderboard1.TabIndex = 4;
            this.buttonLeaderboard1.Text = "Leaderboard";
            this.buttonLeaderboard1.UseVisualStyleBackColor = true;
            this.buttonLeaderboard1.Click += new System.EventHandler(this.buttonLeaderboard1_Click);
            // 
            // labelScore1
            // 
            this.labelScore1.AutoSize = true;
            this.labelScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore1.Location = new System.Drawing.Point(9, 73);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(61, 20);
            this.labelScore1.TabIndex = 1;
            this.labelScore1.Text = "Score:";
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime1.Location = new System.Drawing.Point(9, 34);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(52, 20);
            this.labelTime1.TabIndex = 0;
            this.labelTime1.Text = "Time:";
            // 
            // pictureBoxEmoji1
            // 
            this.pictureBoxEmoji1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEmoji1.Image = global::CatchTheEmoji.Properties.Resources.Без_названия;
            this.pictureBoxEmoji1.Location = new System.Drawing.Point(704, 196);
            this.pictureBoxEmoji1.Name = "pictureBoxEmoji1";
            this.pictureBoxEmoji1.Size = new System.Drawing.Size(107, 104);
            this.pictureBoxEmoji1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmoji1.TabIndex = 5;
            this.pictureBoxEmoji1.TabStop = false;
            this.pictureBoxEmoji1.Visible = false;
            this.pictureBoxEmoji1.Click += new System.EventHandler(this.pictureBoxEmoji1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1352, 727);
            this.Controls.Add(this.pictureBoxEmoji1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1368, 766);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.groupDifficulty1.ResumeLayout(false);
            this.groupDifficulty1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupStatistics1.ResumeLayout(false);
            this.groupStatistics1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmoji1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton gameMod1;
        private System.Windows.Forms.RadioButton gameMod2;
        private System.Windows.Forms.RadioButton gameMod3;
        private System.Windows.Forms.GroupBox groupDifficulty1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupStatistics1;
        private System.Windows.Forms.Label labelWelcome1;
        private System.Windows.Forms.Button buttonStart1;
        private System.Windows.Forms.Button buttonLeaderboard1;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Button buttonExit1;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.PictureBox pictureBoxEmoji1;
    }
}