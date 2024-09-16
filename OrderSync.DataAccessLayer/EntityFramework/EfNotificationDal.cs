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
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(OrderSyncDbContext dbContext) : base(dbContext)
        {
        }

		public void ChangeNotificationToFalse(int id)
		{
			using var context = new OrderSyncDbContext();
			var value = context.Notifications.Find(id);
			value.Status = false;
			context.SaveChanges();
		}

		public void ChangeNotificationToTrue(int id)
		{
			using var context = new OrderSyncDbContext();
			var value = context.Notifications.Find(id);
			value.Status = true;
			context.SaveChanges();
		}

		public List<Notification> GetAllNotificationByFalse()
		{
			using var context = new OrderSyncDbContext();
			return context.Notifications.Where(x => x.Status == false).ToList();
		}

		public int NotificationCountByFalseStatus()
        {
            using var context = new OrderSyncDbContext();
            return context.Notifications.Where(x => x.Status == false).Count();
        }
    }
}
