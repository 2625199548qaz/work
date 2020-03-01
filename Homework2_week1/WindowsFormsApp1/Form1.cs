using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = Convert.ToDouble(textBox1.Text); //num1获取得到了用户在第一个文本框输入的内容
            num2 = Convert.ToDouble(textBox2.Text);

            string s = comboBox1.SelectedItem.ToString();      //用s记录选择框中用户选择的运算符
            switch (s)              //为每个运算符赋予相应功能
            {
                case "+":
                    textBox3.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    textBox3.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if (num2 == 0)
                        textBox3.Text = "除数不能为0，错误";
                    else
                        textBox3.Text = Convert.ToString(num1 / num2);
                    break;
                default:
                    break;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
