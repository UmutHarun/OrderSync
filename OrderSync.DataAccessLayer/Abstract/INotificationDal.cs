using OrderSync.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSync.DataAccessLayer.Abstract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        int NotificationCountByFalseStatus();
        List<Notification> GetAllNotificationByFalse();
        void ChangeNotificationToFalse(int id);
		void ChangeNotificationToTrue(int id);
    }
}
