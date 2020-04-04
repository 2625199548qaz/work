using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1;
        double th2;
        double per1;
        double per2;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            th1 = trackBar_th1.Value * Math.PI / 180.0;     //获取界面滚动条上的右分支角度
            th2 = trackBar_th2.Value * Math.PI / 180.0;     //获取界面滚动条上的左分支角度
            per1 = trackBar_per1.Value/10.0;                //获取右分支长度比
            per2 = trackBar_per2.Value/10.0;                //获取左分支长度比
            if (graphics == null) graphics = panel1.CreateGraphics();       //获取panel画笔
            drawCayleyTree(trackBar_n.Value, 200, 310, trackBar_len.Value, -Math.PI / 2);
        }
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            switch (comboBox_pen.Text)
            {
                case "红色":
                    graphics.DrawLine(
                Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "黄色":
                    graphics.DrawLine(
                Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "蓝色":
                    graphics.DrawLine(
                Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "绿色":
                    graphics.DrawLine(
                Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                default:
                    break;
            }
        }
    }
}
