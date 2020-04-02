using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace OderManagement
{
    public class OrderService
    {
        public List<Order> orderList;          //声明一个订单列表来存放订单
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

        public void Export()        //序列化
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(@"D:\orders.xml", FileMode.Create))
            {
                xmlserializer.Serialize(fs, orderList);
            }
            Console.WriteLine("\nSerialized as XML:");
            Console.WriteLine(File.ReadAllText("s.xml"));
        }
        public void Import()         //反序列化
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(@"D:\orders.xml" , FileMode.Open))
            {
                List<Order> list = (List<Order>)xmlserializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from s.xml");
                foreach (Order o in list)
                    Console.WriteLine(o);
            }

        }
    }
}
