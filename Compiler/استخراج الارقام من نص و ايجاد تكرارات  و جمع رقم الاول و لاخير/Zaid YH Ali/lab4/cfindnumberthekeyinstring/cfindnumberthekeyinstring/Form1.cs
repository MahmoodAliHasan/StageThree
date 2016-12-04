using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cfindnumberthekeyinstring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] number = new string[] { "0", "1", "2", "3", "5", "6", "7", "8", "9" };
        private void button1_Click(object sender, EventArgs e)
        {
            string[] st = null;
            int k = 0;
            st = textBox1.Text.Split(' ');
            string[] newarr = new string[100];
            int i = 0;

            listBox1.Items.Clear();
            foreach (string val in st)
            {
                if (number.Contains(val))
                {
                    listBox1.Items.Add(val);
                    newarr[i] = val;
                    i++;

                }
                else
                {
                    listBox2.Items.Add(val);
                }
                k = i - 1;
            }

            int z=0;
            int h=0;
            for (z = 0; z <= k; z++)
            {
                for(int g=0;g<k;g++)
                {
                        if (newarr[z] == newarr[g]) 
                   
                        if (newarr[z] == newarr[g])
                            h++;
                }
                

            }
            MessageBox.Show(""+h);
            
        }
    }
}
