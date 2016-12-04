using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab4cnumbertoarr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] number = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            string[] st4 = null;
            int k = 0, i=0;
            st4 = textBox1.Text.Split(' ');
            string[] newarr = new string[100]; /* مصفوفه جديده لاضافة فقط الارقام الموجوده في ال textbox  */ 

            listBox1.Items.Clear();
            foreach (string val in st4)
            {
                
                if (number.Contains(val))
                {
                    listBox1.Items.Add(val); /*  فقط للتوضيح  تم اضافه هذا السطر   */
                    newarr[i] = val;
                    i++;
                }

                k = i - 1;
            }
            int first = int.Parse(newarr[0]); /*  جعل اول رقم بالمصوفه في متغير */
            int last = int.Parse(newarr[k]);  /*  جعل اخر رقم بالمصوفه في متغير */

            textBox2.Text = (first + last).ToString(); /* ناتج الجمع اما في textbox */
            MessageBox.Show("The sum =" + (first + last).ToString()); /*  او ناتج الجمع في messagebox */
        }

        

    }
}


        
    
