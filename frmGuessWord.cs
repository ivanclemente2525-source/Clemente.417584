using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        string word = "computer";

        public frmGuessWord()
        {
            InitializeComponent();
            lblWord.Text = "c??????r";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            StringBuilder guess = new StringBuilder(txtGuess.Text);

            if (guess.ToString().ToLower() == word)
            {
                lblWord.Text = word;
                MessageBox.Show("Correct guess!");
            }
            else
            {
                lstWrong.Items.Add(guess.ToString());
                MessageBox.Show("Wrong guess! Try again.");
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

 
    }
}
