using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
    public partial class Form1 : Form
    {
        int num1, num2, result;
        Regex rg = new Regex("/^[0-9]*$");

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Basic Calculator";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(!rg.IsMatch(txtNum1.Text) && !rg.IsMatch(txtNum2.Text))
            {
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);

                if(rdAdd.Checked)
                {
                    result = num1 + num2;
                    MessageBox.Show($"Addition of {num1} and {num2} is {result}","Calculator");

                }

                else if (rdSubtract.Checked)
                {
                    result = num1 - num2;
                    MessageBox.Show($"Subtract of {num1} and {num2} is {result}", "Calculator");
                }

                else if (rdMultiply.Checked)
                {
                    result = num1 * num2;
                    MessageBox.Show($"Multiplication of {num1} and {num2} is {result}", "Calculator");
                }

                if (rdDivide.Checked)
                {
                    try
                    {
                        result = num1 / num2;
                        MessageBox.Show($"Division of {num1} and {num2} is {result}", "Calculator");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }

            else
            {
                MessageBox.Show("Please enter valid inputs for operands");
            }
        }
    }
}
