using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class scoreCalculatorFrm : Form
    {
        public scoreCalculatorFrm()
        {
            InitializeComponent();
        }

        List<int> scores = new List<int>();
        int scoreTotal;
        int scoreCount;
        decimal average;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int newScore = Convert.ToInt32(scoreTxt.Text);
                scores.Add(newScore);

                scoreTotal += newScore;
                scoreTotalResultLbl.Text = Convert.ToString(scoreTotal);

                scoreCount++;
                scoreCountResultLbl.Text = Convert.ToString(scoreCount);

                average = scoreTotal / scoreCount;
                averageResultLbl.Text = Convert.ToString(average);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number");
            }

            scoreTxt.Text = "";
            scoreTxt.Focus();
        }

        private void DisplayScoresBtn_Click(object sender, EventArgs e)
        {
            DisplayScoresFrm resultForm = new DisplayScoresFrm(scores);
            resultForm.ShowDialog();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearScoresBtn_Click(object sender, EventArgs e)
        {
            scores.Clear();
            scoreTxt.Text = "";

            scoreTotal = 0;
            scoreTotalResultLbl.Text = "";

            scoreCount = 0;
            scoreCountResultLbl.Text = "";

            average = 0;
            averageResultLbl.Text = "";
        }
    }
}
