using System;

namespace prime
{
    class Prime
    {
        static void Main(string[] args)
        {
            int num = 0,i;                  //定义一个变量num用来存储用户输入的数据
            Console.Write("请输入数据：");
            int cnum;
            string snum = Console.ReadLine();
            while (!int.TryParse(snum, out cnum))            //解决用户输入数据不是一个整数字符串
            {
                Console.WriteLine("这不是一个有效值，请输入一个数:");      //输入数据错误时会提示用户重新输入
                snum = Console.ReadLine();
            }
            num = Convert.ToInt32(snum);
            Console.WriteLine("用户输入的数据的所有素数因子为：");
            for (i = 2; i <= num; i++)              //循环语句得到用户输入的数据的所有素数因子
            {
                int cout = 0;                           //设置变量为了不重复输出数据
                while (num % i == 0)                //如果num可以整除i
                {
                    if(cout==0)
                        Console.Write(i + "   ");       //i为素数因子，输出
                    num /= i;
                    cout++;
                }
          
            }
        }
    }
}