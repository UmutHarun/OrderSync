﻿using Microsoft.EntityFrameworkCore;
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
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(OrderSyncDbContext dbContext) : base(dbContext)
        {
        }

        public List<Basket> GetBasketByTableNumber(int id)
        {
            using var context = new OrderSyncDbContext();
            return context.Baskets.Where(x => x.MenuTableID == id).Include(y => y.Product).ToList();
        }
    }
}
