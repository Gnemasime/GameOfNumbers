using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
                {
                    int firstNumber = int.Parse(textBox1.Text);
                    int secondNumber = int.Parse(textBox3.Text);
                    int operation = int.Parse(textBox2.Text);

                    switch (operation)
                    {
                        case 1:
                        lblResults.Text = $"Enter the calculation code: \n" +
                        $"1 to get the sum of the two numbers \n" +
                        $"2 to get the difference between the two numbers \n" +
                        $"3 to get the products of the two numbers \n" +
                        $"4 to get the quotient of the two numbers \n" +
                        $"**************************************** \n" +
                        $"  The result is =  {firstNumber + secondNumber}";
                        break;
                        case 2:
                        lblResults.Text = $"Enter the calculation code: \n" +
                         $"1 to get the sum of the two numbers \n" +
                         $"2 to get the difference between the two numbers \n" +
                         $"3 to get the products of the two numbers \n" +
                         $"4 to get the quotient of the two numbers \n" +
                         $"**************************************** \n" +
                         $"  The result is =  {firstNumber - secondNumber}";
                        break;
                    case 3:
                        lblResults.Text = $"Enter the calculation code: \n" +
                         $"1 to get the sum of the two numbers \n" +
                         $"2 to get the difference between the two numbers \n" +
                         $"3 to get the products of the two numbers \n" +
                         $"4 to get the quotient of the two numbers \n" +
                         $"**************************************** \n" +
                         $"  The result is =  {firstNumber * secondNumber}";
                        break;
                        case 4:
                            if (secondNumber != 0)
                            lblResults.Text = $"Enter the calculation code: \n" +
                         $"1 to get the sum of the two numbers \n" +
                         $"2 to get the difference between the two numbers \n" +
                         $"3 to get the products of the two numbers \n" +
                         $"4 to get the quotient of the two numbers \n" +
                         $"**************************************** \n" +
                         $"  The result is =  {firstNumber / (double)secondNumber}";
                        else
                                lblResults.Text = "Error: Division by zero!";
                            break;
                        default:
                           lblResults.Text = "Error: Invalid operation code!";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    lblResults.Text = $"Error: {ex.Message}";
                }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                lblResult.Text = string.Empty;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
