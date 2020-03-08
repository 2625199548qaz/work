using System;

namespace home_week3
{
    public interface Shape          //形状接口
    {
        double CalArea();           //计算图形面积方法
        bool IsLegal();             //判断图形是否正确的方法
    }

    public class Rectangle : Shape      //定义长方形类
    {
        private double l;               //长方形的一边
        private double w;               //长方形的另一边

        public Rectangle(double l,double w)     //构造函数
        {
            this.l = l;
            this.w = w;
        }

        public double CalArea()         //计算长方形面积的方法
        {
            return this.l * this.w;
        }
        virtual public bool IsLegal()       //判断长方形是否正确
        {
            if (l > 0 && w > 0 && l != w)
                return true;
            return false;
        }
    }

    public class Square : Rectangle     //定义正方形，继承了长方形
    {
        private double l;       
        private double w;
        public Square(double l, double w) : base(l, w)
        {
            this.l = l;
            this.w = w;
        }

        override public bool IsLegal()      //判断正方形是否正确
        {
            if (l > 0 && w > 0 && l == w)
                return true;
            return false;
        }
    }
         
        public class Triangle : Shape           //定义三角形
        {
            private double a, b, c;                 //定义三角形的三边
            public Triangle(double a,double b,double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public double CalArea()         //计算三角形的面积
            {
                double p = (a + b + c) / 2;
                return System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            public bool IsLegal()       //判断三角形是否合法
            {
                if ((a + b > c) & (a + c > b) & (b + c > a) & a>0 & b>0 & c>0)
                    return true;
                return false;
            }
        }

        public class Factory            //定义工厂类，用来生产图形
        {
            public static Shape GetShape(int i)         //定义一个静态方法，传入的参数决定生产的图形，0表长方形，1表正方形，2表三角形
            {
                Random ran = new Random(0);
                double a = ran.Next(20);
                double b = ran.Next(30);
                double c = ran.Next(40);
                switch (i)
                {
                    case 0:
                        return new Rectangle(a, b);     //返回一个长方形
                        break;
                    case 1:
                        return new Square(a, a);        //返回一个正方形
                        break;
                    case 2:
                        return new Triangle(a, b, c);       //返回一个三角形
                        break;
                    default:
                        Console.WriteLine("输入数据无效");
                        throw new Exception();
                        break;
                }
            }
        }

      class Using
      {
          static void Main(String[] args)
          {
            Random rand = new Random(0);
            int a = 0;
            double sum = 0;         //用来算生成的10个图形的面积
            int num = 1;            //用来记录生成的次数
            for(int j = 0; j < 10; j++)
            {
                a = rand.Next(0, 3);
                Shape s = Factory.GetShape(a);
                if (s.IsLegal())
                    sum = sum + s.CalArea();
                else
                    Console.WriteLine($"第{num}个图形生产的不正确");
                num++;
            }
            Console.WriteLine("生成的10个图形的总面积（不包括不正确的）为："+sum);       //输出生成的10个图形的总面积
          }
      }
}
