using System;
using System.Collections.Generic;
using System.Text;

namespace OderManagement
{
    class OrderService
    {
        private List<Order> orderList;          //声明一个订单列表来存放订单
        public OrderService()
        {
            orderList = new List<Order>();              
        }
        public void AddOder(Order od)           //添加订单
        {
            if (orderList.Count == 0)
            {
                orderList.Add(od);
                return;
            }
            foreach (Order o in orderList)
            {
                if (od.Equals(o))
                {
                    Console.WriteLine("将要添加的订单已存在，无法添加");
                    return;
                }
            }
            orderList.Add(od);
        }
        public void DeleteOder(Order od)           //删除订单
        {
            if (orderList.Count == 0)
            {
                Console.WriteLine("无订单，删除失败");
                return;
            }
            for(int i = 0; i < orderList.Count; i++)
            {
                if (od.Equals(orderList[i]))
                {
                    orderList.Remove(orderList[i]);
                    return;
                }
            }
            Console.WriteLine("未找到相应订单，订单不存在");
        }
        public void ReviseOder()            //修改订单
        {

        }
        public Order SearchOder(string str)             //查询订单
        {
            if (orderList.Count == 0)
            {
                Console.WriteLine("无订单，查询失败");
                return null;
            }
            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].ID == str)             //根据Id查询
                    return orderList[i];
                if (orderList[i].Client == str)         //根据客户查询
                    return orderList[i];
            }
            Console.WriteLine("未找到相应订单，订单不存在");
            return null;
        }
    }
}
