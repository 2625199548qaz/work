using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OderManagement;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();
            Order order4 = new Order();
            OrderService oservice = new OrderService();
            oservice.AddOder(order1);
            oservice.AddOder(order2);
            oservice.AddOder(order3);
            oservice.AddOder(order4);

            List<Order> ls = new List<Order>();
            ls.Add(order1);
            ls.Add(order2);
            ls.Add(order3);
            ls.Add(order4);
            CollectionAssert.AreEqual(oservice.orderList, ls);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();
            OrderService oservice = new OrderService();
            oservice.AddOder(order1);
            oservice.AddOder(order2);
            oservice.AddOder(order3);
            oservice.DeleteOder(order2);
            List<Order> ls = new List<Order>();
            ls.Add(order1);
            ls.Add(order3);
            CollectionAssert.AreEqual(oservice.orderList, ls);
        }
    }
}

