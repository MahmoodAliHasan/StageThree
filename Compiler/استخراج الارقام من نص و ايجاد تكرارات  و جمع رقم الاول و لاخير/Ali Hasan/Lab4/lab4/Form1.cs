using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] number = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] num = textBox1.Text.Split(' ');

            List<string> list=new List<string>();

            foreach(string s in num)
            {
                foreach(string n in number)
                {
                    if (s == n)
                    {
                        list.Add(s);
                    }
                }
            }
            
            int i = 0;
            for (i = 0; i < list.Count;i++)
            {
                int count = 0;
                if (check(list, i) == 1)
                {
                     
                    foreach (string n in list) { 
                    if (n == list[i])
                        count++;
                    }
                    listBox1.Items.Add(list[i] +"  "+ count);
                }
            }

        }
        public int check(List<string> list,int n)
        {
            int i ;
            
            for (i = n-1; i >=0; i--)
            {
                if (list[n] == list[i])
                        return 0;
            }
            return 1;
        }
    }
}
