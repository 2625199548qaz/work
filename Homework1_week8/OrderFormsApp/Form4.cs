using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFormsApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.Ors.Count; i++)
            {
                if (Form1.Ors[i].OrderId == (uint)Convert.ToInt32(textBox1.Text))
                    Form1.Ors.Remove(Form1.Ors[i]);
            }
            this.Dispose();
        }
    }
}
