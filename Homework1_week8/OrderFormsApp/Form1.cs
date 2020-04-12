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
    public partial class Form1 : Form
    {
        public static List<Order> Ors { get; set; }
        public Form1()
        {
            InitializeComponent();
            OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
            OrderItem egg = new OrderItem(2, "eggs", 1.2, 200);
            OrderItem milk = new OrderItem(3, "milk", 50, 10);

            Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
            Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });

            OrderService os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Ors = os.Orders;
            orderBindingSource.DataSource = Ors;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          for(int i = 0; i < Ors.Count; i++)
            {
                if (Ors[i].OrderId == Convert.ToInt32(textBox1.Text))
                {
                    orderBindingSource.DataSource = Ors[i];
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Ors.Count; i++)
            {
                if (Ors[i].Customer == textBox1.Text)
                {
                    orderBindingSource.DataSource = Ors[i];
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           new Form2().ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = Ors;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }
    }
}
