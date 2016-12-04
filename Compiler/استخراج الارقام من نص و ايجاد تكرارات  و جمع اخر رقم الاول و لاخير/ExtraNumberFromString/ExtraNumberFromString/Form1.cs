using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ExtraNumberFromString
{
    public partial class Form1 :MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = 
                new ColorScheme(Primary.Green500, Primary.Green600, Primary.DeepOrange600, Accent.Indigo100, TextShade.BLACK);
          //  materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;


        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetNumber_Click(object sender, EventArgs e)
        {
            GDV.Rows.Clear();

            List<int> numbers = new List<int>();

            string[] input = richTxt_input.Text.Split(' ');

            int num;
            foreach (string str in input)
                if (int.TryParse(str, out num))
                    numbers.Add(num);




            List<int> countedNumber = new List<int>();
            int count;


            foreach (int num1 in numbers)
            {
                count = 0;
                if (!countedNumber.Contains(num1))
                {
                    foreach (int num2 in numbers)
                        if (num2 == num1)
                            count++;
                    countedNumber .Add(num1);

                    GDV.Rows.Add(num1, count);

                }
            }

            int firstNumber = numbers[0];
            int lastNumber = numbers[numbers.Count - 1];

            lblSumof.Text = "Sum of " + firstNumber + " + " + lastNumber + " = " + (firstNumber + lastNumber);
                


        }

      


    }
}
