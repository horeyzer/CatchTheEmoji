using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CatchTheEmoji
{
    public partial class Game : Form
    {
        private Timer timer = new Timer();
        public int secondsLeft;
        public int time;
        public double score = 0;
        public int difficulty = 0;
        public double ScoreMultiplicator = 0;
        public int boxheight;
        public int boxwidth;
        public int pictureheight;
        public int picturewidth;
        public double score2;
        
        //I think, smth wrong with "timer"
        public Game()
        {
            InitializeComponent();
            Launcher form1 = new Launcher();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;

            labelTime2.Text = secondsLeft.ToString();
            
            pictureheight = pictureBoxEmoji1.Height;
            picturewidth = pictureBoxEmoji1.Width;
            boxheight = this.Height;
            boxwidth = this.Width;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            labelWelcome1.Text = "Welcome,\n " + Launcher.SetValueForText1; // I don't know why I can't get my name from this code on Game.cs [Design]* when program started, so programm will always display "Welcome, nickname" 
            pictureBoxEmoji1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void buttonExit1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void gameMod1_CheckedChanged(object sender, EventArgs e)
        {
            if (gameMod1.Checked == true)
            {
                difficulty = 1; time = 21; ScoreMultiplicator = 1;
            }
        }

        private void gameMod2_CheckedChanged(object sender, EventArgs e)
        {
            if (gameMod2.Checked == true)
            { 
                difficulty = 2; time = 14; ScoreMultiplicator = 2; 
            }
        }

        private void gameMod3_CheckedChanged(object sender, EventArgs e)
        {
            if (gameMod3.Checked == true)
            { 
                difficulty = 3; time = 7; ScoreMultiplicator = 3; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (secondsLeft > 0)
            {
                secondsLeft--;
                labelTime2.Text = secondsLeft.ToString();
            }
            else
            {
                timer.Stop();
                labelTime2.Text = "The end!";
                pictureBoxEmoji1.Visible = false;
            }

        }
        private void buttonStart1_Click(object sender, EventArgs e) // I don't know why I can't change dificulty when program started, it's always in Beginner mod
        {
            if (difficulty != 0)
            {
                secondsLeft = time;
                timer.Enabled = true;
                pictureBoxEmoji1.Visible = true;
            }
            else MessageBox.Show("Choose difficulty");
        }

        private void pictureBoxEmoji1_Click(object sender, EventArgs e) // This code only for one pictureBox, I don't know how to change it and make it in separate class for 3 and more picture boxes
        {
            if (secondsLeft > 0)
            {
                Random r = new Random();
                score += ScoreMultiplicator;
                score2 += 1;
                if (score2 == 10)
                {
                    labelTime2.Text = "Reward";
                    secondsLeft = time;
                    score2 = 0;
                    pictureBoxEmoji1.Width = Convert.ToInt32(picturewidth * 0.8);
                    picturewidth = Convert.ToInt32(picturewidth * 0.8);
                    pictureBoxEmoji1.Height = Convert.ToInt32(pictureheight * 0.8);
                    pictureheight = Convert.ToInt32(pictureheight * 0.8);
                    this.Height = Convert.ToInt32(boxheight * 1.2);
                    boxheight = Convert.ToInt32(boxheight * 1.2);
                    this.Width = Convert.ToInt32(boxwidth * 1.2);
                    boxwidth = Convert.ToInt32(boxwidth * 1.2);
                }
                labelScore2.Text = score.ToString();
                pictureBoxEmoji1.Location = new Point(r.Next(332, boxwidth - picturewidth), r.Next(pictureheight, boxheight - pictureheight));
            }
            else MessageBox.Show("Game over!");
        }

        private void buttonLeaderboard1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recently this function doesn't working :/");
        }
    }
}
