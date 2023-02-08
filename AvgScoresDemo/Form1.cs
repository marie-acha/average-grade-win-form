using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AvgScoresDemo
{
    public partial class Form1 : Form
    {
        List<Score> ScoreList = new List<Score>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadScoreButton_Click(object sender, EventArgs e)
        {
            ScoreList.Clear();
            try
            {
                using (StreamReader loadScoreDataStream = new StreamReader("TestScores.txt"))
                {
                    string eachScore;
                    if (!loadScoreDataStream.EndOfStream)
                    {
                        eachScore = loadScoreDataStream.ReadLine();
                        MessageBox.Show("Loading " + eachScore + " scores in the list.");
                    }
                    while (!loadScoreDataStream.EndOfStream)
                    {
                        eachScore = loadScoreDataStream.ReadLine();
                        //string eachScores = eachScore;
                        double.TryParse(eachScore, out double score);
                        Score eachScoreItem = new Score(score);
                        ScoreList.Add(eachScoreItem);
                    }
                }
                LoadScoresToListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LoadScoresToListBox()
        {
            LoadScoresListBox.Items.Clear();
            LoadScoresListBox.Items.Add("Scores");
            foreach(Score scoreItem in ScoreList)
            {
                LoadScoresListBox.Items.Add(scoreItem);
            }
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            double maxScore = ScoreList.Max(s => s.Scores);
            double minScore = ScoreList.Min(s => s.Scores);
            double avgScore = ScoreList.Average(s => s.Scores);

            MinGradeLabel.Text = minScore.ToString();
            MaxGradeLabel.Text = maxScore.ToString();
            AvgGradeLabel.Text = avgScore.ToString("F2");
        }
    }
}
