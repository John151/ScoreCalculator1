using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator1
{
    public partial class ScoreCalculator : Form
    {
        public ScoreCalculator()
        {
            InitializeComponent();
        }

        double scoreTotal = 0;
        int scoreCount = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            double score = Convert.ToDouble(txtScore.Text);
            scoreTotal += score;
            scoreCount += 1;

            //simple math
            double average = scoreTotal / scoreCount;

            txtAverage.Text = Convert.ToString(average);
            txtScoreTotal.Text = Convert.ToString(scoreTotal);
            txtScoreCount.Text = Convert.ToString(scoreCount);
        }

        private void txtScoreTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double scoreTotal = 0;
            int scoreCount = 0;
            double average = 0;

            txtAverage.Text = Convert.ToString(average);
            txtScoreTotal.Text = Convert.ToString(scoreTotal);
            txtScoreCount.Text = Convert.ToString(scoreCount);
        }
    }
}
