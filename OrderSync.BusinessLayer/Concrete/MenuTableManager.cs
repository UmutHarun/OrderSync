using OrderSync.BusinessLayer.Abstract;
using OrderSync.DataAccessLayer.Abstract;
using OrderSync.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSync.BusinessLayer.Concrete
{
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;

        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public void TAdd(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MenuTable entity)
        {
            throw new NotImplementedException();
        }

        public List<MenuTable> TGetAll()
        {
            throw new NotImplementedException();
        }

        public MenuTable TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public int TTotalMenuTableCount()
        {
            return _menuTableDal.TotalMenuTableCount();
        }

        public void TUpdate(MenuTable entity)
        {
            throw new NotImplementedException();
        }
    }
}
