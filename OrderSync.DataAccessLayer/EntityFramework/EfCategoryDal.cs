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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(OrderSyncDbContext dbContext) : base(dbContext)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new OrderSyncDbContext();
            return context.Products.Where(x => x.ProductStatus == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new OrderSyncDbContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new OrderSyncDbContext();
            return context.Products.Where(x => x.ProductStatus == false).Count();
        }
    }
}
