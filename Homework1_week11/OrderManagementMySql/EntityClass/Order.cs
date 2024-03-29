﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementMySql.EntityClass
{
    public class Order
    {
        private string orderId;                 //订单号
        private double money;           //订单的总金额
        private string client;          //订单的客户
        private OrderItem[] ordItem;
        public string OrderId                    //订单号
        {
            get;
            set;
        }
        public double Money                     //订单的总金额
        {
            get;
            set;
        }
        public string Client                    //订单的客户
        {
            get;
            set;
        }

        public OrderItem[] OrdItems
        {
            get;
            set;
        }
        public Order()     //构造函数，完成对订单以及订单细项的初始化
        {
            Random random = new Random();
            orderId = random.Next(1000).ToString();
            Console.Write("请输入你的名字:");
            client = Console.ReadLine();
            Console.Write("输入要买多少种商品");
            int n = Convert.ToInt32(Console.ReadLine());
            ordItem = new OrderItem[n];
            for (int j = 0; j < n; j++)
            {
                Console.Write("输入你要买的商品名称");
                string name = Console.ReadLine();
                Console.Write("输入你要买的商品的数量");
                int num = Convert.ToInt32(Console.ReadLine());
                double price = random.NextDouble() * 10;
                ordItem[j] = new OrderItem(num, name, price);
            }
        }
        public void CalcuteMoney()              //计算订单的总金额
        {
            double sum = 0;
            if (ordItem.Length != 0)
            {
                for (int i = 0; i < ordItem.Length; i++)
                    sum = sum + ordItem[i].Num * ordItem[i].Price;
                money = sum;
            }
            Console.WriteLine("当前订单不存在商品");
        }
        public override string ToString()
        {
            string s = "订单号为：" + orderId + "   " + "订单金额为：" + money + "   " + "订单客户为：" + client + " ";
            for (int k = 0; k < ordItem.Length; k++)
            {
                s = s + ordItem[k].ToString();
            }
            return s;
        }
        public override bool Equals(object obj)
        {
            Order od = obj as Order;
            return od.orderId == orderId;
        }
    }
}
