using OrderSync.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSync.BusinessLayer.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        int TNotificationCountByFalseStatus();
        List<Notification> TGetAllNotificationByFalse();
        void TChangeNotificationToFalse(int id);
        void TChangeNotificationToTrue(int id);
	}
}
