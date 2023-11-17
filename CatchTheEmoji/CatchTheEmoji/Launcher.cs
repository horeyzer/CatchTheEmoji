using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CatchTheEmoji
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }
        

        private void infoButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is simple game from team: coder'Scry.\nDeveloped by:\nID63274, ID63374, ID63513, ID63535, ID63879", "INFO", MessageBoxButtons.OK);
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void playButton1_Click(object sender, EventArgs e)
        {
            if (userName1.TextLength >= 1)
            {
                Game f2 = new Game();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Before this action, enter your name", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static string SetValueForText1 = "";

        private void userName1_TextChanged(object sender, EventArgs e)
        {
            SetValueForText1 = userName1.Text; // I don't know why I can't get my name from this code on Game.cs [Design]* when program started, so programm will always display "Welcome, nickname" 
            FileStream fs = new FileStream("playerslist.txt", FileMode.OpenOrCreate, FileAccess.Write); // We should add liderboard list with nicknames and scores
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine(userName1.Text);
            sr.Close();
            fs.Close();
        }

    }
}
