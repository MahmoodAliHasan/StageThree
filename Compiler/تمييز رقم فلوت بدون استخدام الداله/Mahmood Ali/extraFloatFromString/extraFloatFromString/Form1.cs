using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extraFloatFromString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string[] inputs = txtInput.Text.Split(' ');

            floatLBox.Items.Clear();

            foreach (string str in inputs)
                if (isFloat(str))
                    floatLBox.Items.Add(str);
        }

        private bool isFloat(string str)
        {
            string[] dividedString = str.Split('.');
            // 444.3434.34 - > 3
            //44.23 - >  2

            int temp;
            if(dividedString.Length == 2)
            {
                string leftString = dividedString[0];
                string rightString = dividedString[1];

                if (!int.TryParse(leftString, out temp))
                    return false;

                if (!int.TryParse(rightString, out temp))
                    return false;

            }
            else
                return false;

            return true;
                     
        }



    }
}
