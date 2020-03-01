using System;

namespace IntArray
{
    class Program
    {
        static void Array(int[] array)
        {
            int i;
            int max = array[0];             //定义一个max变量存储数组中的最大值
            int min = array[0];             
            int sum=0;
            double aver;
            for (i = 0; i < array.Length; i++)      //遍历数组
            {
                if (max < array[i])                 //当数组中有比max大的数据时，将该值赋给max
                    max = array[i];
                if (min > array[i])                 //当数组中有比min小的数时，将该值赋给min
                    min = array[i];
                sum += array[i];                    //数组所有元素之和
            }
            aver = sum / array.Length;              //求平均值
            Console.WriteLine("数组的最大值为：" + max);
            Console.WriteLine("数组的最小值为：" + min);
            Console.WriteLine("数组的所有元素值之和为：" + sum);
            Console.WriteLine("数组的平均值为：" + aver);
        }
        static void Main(string[] args)
        {
            int[] s = { 5, 6, 8, 45, 69, 10, 2, 3, 0, 68 };
            Array(s);
        }
    }
}
