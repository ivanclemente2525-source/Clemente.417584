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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void showletters_Click(object sender, EventArgs e)
        {
            letters1.Items.Clear();

            char[,] letters =
            {
                { 'A', 'B', 'C' },
                { 'D', 'E', 'F' }
            };

            for (int i = 0; i < 2; i++)
            {
                string row = "";

                for (int j = 0; j < 3; j++)
                {
                    row += letters[i, j] + " ";
                }

                letters1.Items.Add(row);
            }
        }

       
       

    }
}
