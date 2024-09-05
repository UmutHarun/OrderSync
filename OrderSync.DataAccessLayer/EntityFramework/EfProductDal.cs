using Microsoft.EntityFrameworkCore;
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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(OrderSyncDbContext dbContext) : base(dbContext)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new OrderSyncDbContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public int ProductCount()
        {
            using var context = new OrderSyncDbContext();
            return context.Products.Count();
        }

        public int ProductCountByDrink()
        {
            using var context = new OrderSyncDbContext();
            return context.Products.Where(x => x.Category.CategoryName == "Drink").Count(); //test amaçlı
        }

        //return context.Products.Count(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryID)).FirstOrDefault());

        public int ProductCountByHamburger()
        {
            using var context = new OrderSyncDbContext();
            return context.Products.Where(x => x.Category.CategoryName == "Hamburger").Count(); //test amaçlı
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new OrderSyncDbContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new OrderSyncDbContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new OrderSyncDbContext();
            return context.Products.Average(x => x.Price);
        }
    }
}
