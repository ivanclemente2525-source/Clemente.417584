using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }
            private void Generateava_Click(object sender, EventArgs e)
        {

            double english = Convert.ToDouble(Englishtxtbox.Text);
            double math = Convert.ToDouble(Mathtxtbox.Text);
            double science = Convert.ToDouble(Sciencetxtbox.Text);
            double filipino = Convert.ToDouble(Filipinotxtbox.Text);
            double history = Convert.ToDouble(Historytxtbox.Text);

            double average = (english + math + science + filipino + history) / 5;

            lblStatus.Text = (average > 75.00) ? "The Student Passed." : "The Student Failed";
            lblStatus.Text = "The general average of " + Nametxt.Text + " is " + average.ToString("F2") + ".";

            try
            {

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid number");
            }

   

        }

       

        }
    }

