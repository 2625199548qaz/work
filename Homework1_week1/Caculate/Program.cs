using System;

namespace Caculate
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1=0, num2=0;             //创建两个变量来接受用户输入
            Console.Write("请输入第一个数据：");
            double cnum1 = 0;
            try                                 //检测输入数据超出范围的异常
            {
                string snum1 = Console.ReadLine();
                while (!double.TryParse(snum1, out cnum1))      //保证用户输入的是一个数字
                {
                    Console.WriteLine("这不是一个有效值，请输入一个数:");
                    snum1 = Console.ReadLine();
                }

                num1 = Convert.ToDouble(snum1);             //当用户输入的是数字时，才转换
            }
            catch (Exception e)
            {
                Console.WriteLine("输入数据超过范围了");
            }

            Console.Write("请输入第二个数据：");
            double cnum2 = 0;
            try
            {
                string snum2 = Console.ReadLine();
                while (!double.TryParse(snum2, out cnum1))
                {
                    Console.WriteLine("这不是一个有效值，请输入一个数:");
                    snum2 = Console.ReadLine();
                }
                num2 = Convert.ToDouble(snum2);
            }catch(Exception e)
            {
                Console.WriteLine("输入数值超出范围");
            }

            Console.Write("请输入运算符：+,-,*或/：");
            try
            {
                switch (Console.ReadLine())          //定义用户输入的符号的功能
                {
                    case "+":
                        Console.WriteLine($"{num1}+{num2}的结果为：" + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"{num1}-{num2}的结果为：" + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"{num1}*{num2}的结果为：" + (num1 * num2));
                        break;
                    case "/":
                        while (num2 == 0)       //除数为0时
                        {
                            Console.WriteLine("num2为除数，不能为0，请重新输入num2的值");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine($"{num1}/{num2}的结果为：" + (num1 / num2));
                        break;
                    default:
                        break;
                }
            }catch(Exception e)
            {
                Console.WriteLine("计算结果超出范围");
            }
        }
    }
}
