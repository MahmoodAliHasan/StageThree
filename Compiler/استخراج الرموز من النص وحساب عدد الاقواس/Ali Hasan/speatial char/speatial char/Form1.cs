using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speatial_char
{
    public partial class Form1 : Form
    {
        int count1;
        int count2;
        string[] names = { "*", "/", "-", "+", ")", "(", "=" };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] content = textBox1.Text.Split(' ');
            foreach (string n in content)
                foreach (string name in names)
                {
                    if (n == name)
                    {
                        listBox1.Items.Add(n);
                    }

                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count2 = 0;
            count1 = 0;
            string[] content = textBox1.Text.Split(' ');
            foreach (string n in content)
                foreach (string name in names)
                {
                    if (n == "(")
                    {
                        count1++;
                    }
                    else if (n == ")")
                    {
                        count2++;
                    }
                }


            if (count1 == count2)
                MessageBox.Show(") is equal ( in the code");
            else
                MessageBox.Show(") is not equal ( in the code");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] content = textBox1.Text.Split(' ');
            foreach(string s in content)
            {
                MessageBox.Show(s);
            }
        }
    }
}
