using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recognize_float
{
    public partial class Form1 : Form
    {
        public int i;
        public int x;
        string[] num;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] wrords = textBox1.Text.Split(' ');

            for (i = 0; i < wrords.Length; i++)
            {
                if (wrords[i].Contains('.'))
                {
                    num = wrords[i].Split('.');
                    foreach (string n in num)
                    {
                        int.TryParse(n, out x);
                        listBox1.Items.Add(x);

                    }
                }

            }          
