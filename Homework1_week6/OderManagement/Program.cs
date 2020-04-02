using System;

namespace OderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            OrderService oservice = new OrderService();
            oservice.AddOder(order1);
            oservice.DeleteOder(order1);
            oservice.Export();
            oservice.Import();
        }
    }
}
