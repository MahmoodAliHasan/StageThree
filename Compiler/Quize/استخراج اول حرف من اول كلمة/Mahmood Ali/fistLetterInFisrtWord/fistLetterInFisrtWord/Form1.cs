using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fistLetterInFisrtWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string[] words = txtInput.Text.Split(' ');

            string firstWord=words[0];
                  
            char firstLetter = firstWord.Length > 0 ? firstWord[0] : ' ' ;

            MessageBox.Show(firstLetter.ToString());

            // Or 

           // MessageBox.Show(words[0][0].ToString());
        }


       
    }
}
