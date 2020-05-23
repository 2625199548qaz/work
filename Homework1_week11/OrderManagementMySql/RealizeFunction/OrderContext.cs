using OrderManagementMySql.EntityClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementMySql.ControlFunction
{
    public class OrderContext:DbContext
    {
        public OrderContext():base ("OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Order> Orders { get; set; }        //在数据库中建订单表
        public DbSet<OrderItem> OrderItems { get; set; }        //在数据库中建订单明细表
    }
}
