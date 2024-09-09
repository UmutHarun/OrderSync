using OrderSync.DataAccessLayer.Abstract;
using OrderSync.DataAccessLayer.Concrete;
using OrderSync.DataAccessLayer.Repositories;
using OrderSync.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSync.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(OrderSyncDbContext dbContext) : base(dbContext)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new OrderSyncDbContext();
            return context.Orders.Where(x => x.Description == "Preparing").Count();
        }

        public decimal TodayTotalPrice()
        {
            using var context = new OrderSyncDbContext();
            return context.Orders.Where(x => x.OrderDate==DateTime.Today).Sum(x => x.TotalPrice);
        }

        public int TotalOrderCount()
        {
            using var context = new OrderSyncDbContext();
            return context.Orders.Count();
        }
    }
}
