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
			_menuTableDal.Add(entity);

		}

        public void TDelete(MenuTable entity)
        {
			_menuTableDal.Delete(entity);
		}

        public List<MenuTable> TGetAll()
        {
            return _menuTableDal.GetAll();
        }

        public MenuTable TGetById(int id)
        {
            return _menuTableDal.GetById(id);
		}

        public int TTotalMenuTableCount()
        {
            return _menuTableDal.TotalMenuTableCount();
        }

        public void TUpdate(MenuTable entity)
        {
            _menuTableDal.Update(entity);
		}
    }
}
