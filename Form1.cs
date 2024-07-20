using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_Inputes.Text+='1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '0';
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '.';
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '+';
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '-';
        }

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '*';
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            user_Inputes.Text += '/';
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            user_Inputes.Text = string.Empty;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(user_Inputes.Text))
            {
                user_Inputes.Text = user_Inputes.Text.Remove(user_Inputes.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("It is empty, please add a number.");
            }
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            string input = user_Inputes.Text;
            DataTable dt = new DataTable();
            var result = dt.Compute(input, "");
            lbl_Answer.Text = $"{input} = "+result.ToString();
            user_Inputes.Text = string.Empty;

        }

        private void user_Inputes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
