using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DAYS.Items.Add("-Day-");
            Month.Items.Add("-Month-");
            Years.Items.Add("-Year-");

            for (int day = 1; day <= 31; day++)
            {
                DAYS.Items.Add(day);
            }

            for (int month = 1; month <= 12; month++)
            {
                Month.Items.Add(month);
            }

            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                Years.Items.Add(year);
            }

            DAYS.SelectedIndex = 0;
            Month.SelectedIndex = 0;
            Years.SelectedIndex = 0;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LastnameBox1.Text))
            {
                MessageBox.Show("Please enter the last name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastnameBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(FirstnameBox2.Text))
            {
                MessageBox.Show("Please enter the first name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstnameBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(MiddlenameBox3.Text))
            {
                MessageBox.Show("Please enter the middle name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MiddlenameBox3.Focus();
                return;
            }

            if (!Malebutton.Checked && !Femalebutton.Checked)
            {
                MessageBox.Show("Please select a gender.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DAYS.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a day.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Month.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a month.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Years.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a year.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string day = DAYS.SelectedItem.ToString();
            string month = Month.SelectedItem.ToString();
            string year = Years.SelectedItem.ToString();

            string gender = "";
            if (Malebutton.Checked)
            {
                gender = "Male";
            }
            else if (Femalebutton.Checked)
            {
                gender = "Female";
            }

            string fullName = FirstnameBox2.Text + " " + MiddlenameBox3.Text + " " + LastnameBox1.Text;
            string dateOfBirth = day + "/" + month + "/" + year;

            string message = "Student name: " + fullName + "\n"
                           + "Gender: " + gender + "\n"
                           + "Date of birth: " + dateOfBirth;

            MessageBox.Show(message);


        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {

        }
    }
}