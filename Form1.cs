using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06QUIZ_DimensionalArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            string[] classmates = { "Ivan", "Bene", "Nick", "Lamar", "Michael", "Jofred", };
            foreach (string name in classmates)
            {
                NAMES.Items.Add(name);
            }

        }

        private void nextbutton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }
    }
}