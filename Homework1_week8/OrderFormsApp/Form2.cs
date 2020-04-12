using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OrderService os = new OrderService();
            for(int i = 0; i < Form1.Ors.Count; i++)
            {
                os.AddOrder(Form1.Ors[i]);
            }
            OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
            OrderItem egg = new OrderItem(2, "eggs", 1.2, 200);
            OrderItem milk = new OrderItem(3, "milk", 50, 10);
            List<OrderItem> item = new List<OrderItem>();
            if (appleCheckBox.Checked == true)
                item.Add(apple);
            if (eggsCheckBox.Checked == true)
                item.Add(egg);
            if (milkCheckBox.Checked == true)
                item.Add(milk);
            Order ordered = new Order((uint)Convert.ToInt32(textBox1.Text), textBox2.Text, item);
            os.AddOrder(ordered);
            Form1.Ors = os.Orders;
            this.Dispose();
        }
    }
}
