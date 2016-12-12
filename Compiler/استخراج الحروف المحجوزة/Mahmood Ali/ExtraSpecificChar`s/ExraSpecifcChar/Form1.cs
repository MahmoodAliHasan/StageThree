using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExraSpecifcChar
{
    public partial class Form1 : Form
    {
        private char[] speChar;
        public Form1()
        {
            InitializeComponent();

            speChar=new char[] { '+','-', '/' ,'*',';','(',')','>','<'};
           
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            string[] inputStr = txtInput.Text.Split(' ');

            lbox_char.Items.Clear();

            int openParenthese = 0;
            int closeParenthese = 0;

           
            foreach (string str in inputStr)

                foreach (char ch in speChar)
                    if ( ch.ToString().Contains(str))
                    {
                        if (ch == '(')
                            openParenthese++;
                        else if (ch == ')')
                            closeParenthese++;

                        lbox_char.Items.Add(str);
                    }

            if (openParenthese == closeParenthese)
                MessageBox.Show("Parenthese Equal");
            else
                MessageBox.Show("Parenthese no Equal");
                        
        }
    }
}
