using OrderSync.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSync.BusinessLayer.Abstract
{
    public interface IMenuTableService : IGenericService<MenuTable>
    {
        int TTotalMenuTableCount();
    }
}
