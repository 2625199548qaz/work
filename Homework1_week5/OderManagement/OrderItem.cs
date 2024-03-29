﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OderManagement
{
    class OrderItem
    {
        private int num;         //商品数量
        private string productName;     //商品名称
        private double price;           //商品单价
        public int Num
        {
            get => num;
        }
        public string ProductName
        {
            get => productName;
        }
        public double Price
        {
            get => price;
        }

        public OrderItem(int num , string productName , double price)       //构造函数
        {
            this.num = num;
            this.productName = productName;
            this.price = price;
        }
        public override string ToString()
        {
            return "商品名称为："+productName+"   "+"商品数量为："+num+"    "+"商品单价为："+price+"  ";
        }
        public override bool Equals(object obj)
        {
            OrderItem ord = obj as OrderItem;
            return ord.productName == productName;
        }
    }
}
