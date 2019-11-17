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
    public partial class DisplayScoresFrm : Form
    {
        public DisplayScoresFrm(List<int> scores)
        {
            InitializeComponent();
            currentScores = scores;
            DisplayScores();
        }

        private List<int> currentScores;

        private void DisplayScores()
        {
            for (int i = 0; i < currentScores.Count(); i++)
            {
                resultLst.Items.Add(Convert.ToString(currentScores[i]));
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
