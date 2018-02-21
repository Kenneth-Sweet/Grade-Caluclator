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

namespace FinalGradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

                        
        private void button1_Click(object sender, EventArgs e)
        {
            string[] correctArray = new string[] { "B", "D", "A", "A", "C", "A", "B", "B", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
            string[] studentArray = File.ReadAllLines("Responses.txt");
            const double pass = 13;
            double correctAnswers = 0;
            double incorrectAnswers = 0;
            string wrongAnswers = "";

            for (int index = 0; index < correctArray.Length; index++)

            {
                if (correctArray[index] == studentArray[index])
                {
                    correctAnswers += 1;                  
                }
               
                else
                {
                    incorrectAnswers += 1;
                    wrongAnswers = wrongAnswers + " " + index.ToString();
                }

                if (correctAnswers > pass)
                {
                    passOrFailBox.Text = "Pass";
                }
                else
                {
                    passOrFailBox.Text = "Fail";
                }
                
                
                
            }
            questionsMissedBox.Text = wrongAnswers.ToString();
            correctAnswerBox.Text = correctAnswers.ToString();
            incorrectAnswerBox.Text = incorrectAnswers.ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
