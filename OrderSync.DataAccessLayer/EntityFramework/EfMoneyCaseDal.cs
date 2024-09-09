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
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        public EfMoneyCaseDal(OrderSyncDbContext dbContext) : base(dbContext)
        {
        }

        public decimal TotalMoneyCaseAmount()
        {
            using var context = new OrderSyncDbContext();
            return context.MoneyCases.Select(x => x.TotalAmount).Sum();
        }
    }
}
