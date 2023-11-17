namespace CatchTheEmoji
{
    partial class Launcher
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
            this.gameName1 = new System.Windows.Forms.Label();
            this.gameName2 = new System.Windows.Forms.Label();
            this.userName1 = new System.Windows.Forms.TextBox();
            this.infoButton1 = new System.Windows.Forms.Button();
            this.playButton1 = new System.Windows.Forms.Button();
            this.exitButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameName1
            // 
            this.gameName1.AutoSize = true;
            this.gameName1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName1.Location = new System.Drawing.Point(85, 25);
            this.gameName1.Name = "gameName1";
            this.gameName1.Size = new System.Drawing.Size(152, 22);
            this.gameName1.TabIndex = 0;
            this.gameName1.Text = "Catch the emoji";
            // 
            // gameName2
            // 
            this.gameName2.AutoSize = true;
            this.gameName2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName2.Location = new System.Drawing.Point(12, 60);
            this.gameName2.Name = "gameName2";
            this.gameName2.Size = new System.Drawing.Size(298, 15);
            this.gameName2.TabIndex = 1;
            this.gameName2.Text = "Enter your name below and press Play button";
            // 
            // userName1
            // 
            this.userName1.Location = new System.Drawing.Point(129, 88);
            this.userName1.Multiline = true;
            this.userName1.Name = "userName1";
            this.userName1.Size = new System.Drawing.Size(148, 20);
            this.userName1.TabIndex = 2;
            this.userName1.TextChanged += new System.EventHandler(this.userName1_TextChanged);
            // 
            // infoButton1
            // 
            this.infoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton1.Location = new System.Drawing.Point(15, 117);
            this.infoButton1.Name = "infoButton1";
            this.infoButton1.Size = new System.Drawing.Size(76, 23);
            this.infoButton1.TabIndex = 3;
            this.infoButton1.Text = "Info";
            this.infoButton1.UseVisualStyleBackColor = true;
            this.infoButton1.Click += new System.EventHandler(this.infoButton1_Click);
            // 
            // playButton1
            // 
            this.playButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton1.Location = new System.Drawing.Point(15, 88);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(76, 23);
            this.playButton1.TabIndex = 4;
            this.playButton1.Text = "Play";
            this.playButton1.UseVisualStyleBackColor = true;
            this.playButton1.Click += new System.EventHandler(this.playButton1_Click);
            // 
            // exitButton1
            // 
            this.exitButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton1.Location = new System.Drawing.Point(15, 146);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(75, 23);
            this.exitButton1.TabIndex = 5;
            this.exitButton1.Text = "Exit";
            this.exitButton1.UseVisualStyleBackColor = true;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(321, 190);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.playButton1);
            this.Controls.Add(this.infoButton1);
            this.Controls.Add(this.userName1);
            this.Controls.Add(this.gameName2);
            this.Controls.Add(this.gameName1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName1;
        private System.Windows.Forms.Label gameName2;
        private System.Windows.Forms.TextBox userName1;
        private System.Windows.Forms.Button infoButton1;
        private System.Windows.Forms.Button playButton1;
        private System.Windows.Forms.Button exitButton1;
    }
}

