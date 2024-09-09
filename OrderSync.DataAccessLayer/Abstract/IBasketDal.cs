using OrderSync.DataAccessLayer.Repositories;
using OrderSync.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSync.DataAccessLayer.Abstract
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        public List<Basket> GetBasketByTableNumber(int id);
    }
}
