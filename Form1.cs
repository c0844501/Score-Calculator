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
    public partial class ScoreCalculator : Form
    {
        //class Variables 
        double scoreTotal, scoreCount;

        public ScoreCalculator()
        {
            InitializeComponent();
        }

        private void ScoreCalculator_Load(object sender, EventArgs e)
        {

        }
        
        private void btnClearScores_Click(object sender, EventArgs e)
        {   
            //Reset the TextBoxes Values to empty.
            scoreTotal = 0;
            scoreCount = 0;
            txtAverage.Text = "";
            txtScore.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
            //Reset the Focus to the textbox named txtScore
            txtScore.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double average;
            //Read the value from the user and store into the variable named score 
            int score=Convert.ToInt32(txtScore.Text);
            //Calculate the total score and score count
            scoreTotal = scoreTotal+ score;
            scoreCount = scoreCount + 1;
            //Calculate the average score
            average = scoreTotal / scoreCount;
            //Rounding off the average upto 2 digits
            average = Math.Round(average, 2);
            //Display the output into the textBoxes
            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = average.ToString();
            //Reset the Focus to the textbox named txtScore
            txtScore.Focus();
            //Reset the textbox to the empty.
            txtScore.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /***********************************************************************************
                                            joke of the Day
            ************************************************************************************                                 
            * Teacher: Class, we will have only half a day of school this morning.
            * Class: Hooray!
            * Teacher: We will have the other half this afternoon.
            ***********************************************************************************/

            // Close the Application 
            this.Close();
        }
    }
}
