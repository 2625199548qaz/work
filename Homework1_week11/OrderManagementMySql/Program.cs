using OrderManagementMySql.EntityClass;
using OrderManagementMySql.ControlFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementMySql
{
    public class Program
    {
        static void Main(string[] args)
        {
            int operate; // 操作的类型
            OrderService os = new OrderService();
            while (true)
            {  
             // 提示

                    Console.WriteLine("\n请输入需要执行的操作（整数）");
                    Console.WriteLine("1:增加订单，2:删除订单，3:查询订单");
                    operate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (operate)
                    {
                        case 1:
                            Order or = new Order();
                            os.AddOder(or);
                            Console.WriteLine();
                            break;
                        case 2:
                        Console.WriteLine("请用户输入想删除的订单的Id:");
                        string odId;
                        odId = Console.ReadLine();
                        os.DeleteOder(odId);
                        Console.WriteLine();
                            break;
                        case 3:
                        Console.WriteLine("请用户输入想查询的订单的Id或客户:");
                        string s;
                        s = Console.ReadLine();
                        os.SearchOder(s);
                        Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("输入指令错误，请重新输入");
                            break;
                    }
            }
        }
    }
}
