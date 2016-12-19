using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveComment
{
    public partial class Form1 : Form
    {
        private string[] inputStr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpilt_Click(object sender, EventArgs e)
        {
            inputStr = txt_input.Text.Split(' ');

     
        }

        private void btn_NoOfWord_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inputStr.Length.ToString());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            rich_output.Text = "";

            int j = 0;
            string[] temp = inputStr;

            inputStr = new string[LengthOfNewString()];

            foreach (string s in temp)
                if (s != "/*" && s != "*/")
                {
                    inputStr[j++] = s;
                    rich_output.Text += s+ " ";
                }
                   
            // for check only 
            //foreach (var str in inputStr)
            //    MessageBox.Show(str);

            rich_output.Text += "\n" + "no of word is :" + inputStr.Length ;

           
        }

        private int LengthOfNewString()
        {
            int count = 0;
            foreach (string s in inputStr)
                if (s != "/*" && s != "*/")
                    count++;
            return count;
        }

       
    }
   
}
