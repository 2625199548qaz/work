using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementMySql.EntityClass
{
    public class OrderItem
    {
        private int num;         //商品数量
        private string productName;     //商品名称
        private double price;           //商品单价

        public string OrderItemId
        {
            get;
            set;
        }
        public int Num
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        [ForeignKey("OrderId")]
        public string OrderId
        {
            get;
            set;
        }

        public OrderItem(int num, string productName, double price)       //构造函数
        {
            this.num = num;
            this.productName = productName;
            this.price = price;
        }
        public override string ToString()
        {
            return "商品名称为：" + productName + "   " + "商品数量为：" + num + "    " + "商品单价为：" + price + "  ";
        }
        public override bool Equals(object obj)
        {
            OrderItem ord = obj as OrderItem;
            return ord.productName == productName;
        }
    }
}
