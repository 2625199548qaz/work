using System;

namespace sieve
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isprime = new bool[101];            //用一个数组来记录0-100的数哪些为素数
            for (int i = 0; i < isprime.Length; i++)   //初始都置为true
                isprime[i] = true;
            isprime[0] = isprime[1] = false;            //0和1肯定不是素数，置为false
            Console.WriteLine("2-100内的素数为：");
            for(int i = 2; i <= 10; i++)       //从2开始往后筛选，一直到10
            {
                if (!isprime[i])               //如果不是素数，则跳过该次循环  
                {
                    continue;
                }
                for (int j = i * 2; j <= 100; j = j + i)      //是素数，则所有可以整除该素数的数均不是素数，置为false
                    isprime[j] = false;
            }
            for(int k = 0; k < isprime.Length; k++)           //输出所有的素数
            {
                if (isprime[k])
                    Console.Write(k + "   ");
            }
        }
    }
}
