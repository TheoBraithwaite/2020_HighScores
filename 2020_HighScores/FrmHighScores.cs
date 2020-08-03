using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_HighScores
{
    public partial class FrmHighScores : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";
        List<HighScores> highScores = new List<HighScores>();
        public FrmHighScores(string playerName, string playerScore)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            lblPlayerName.Text = playerName;
            lblPlayerScore.Text = playerScore;
            var reader = new StreamReader(binPath);
            //Declares a new StreamReader called reader

            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                var values = line.Split(',');
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1])));
            }
        }
        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                ListBoxName.Items.Add(s.Name);
                ListBoxScore.Items.Add(s.Score);

            }
        }

        private void FrmHighScores_Load(object sender, EventArgs e)
        {
            DisplayHighScores();
        }
    }
}
