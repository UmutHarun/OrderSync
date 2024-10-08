﻿using OrderSync.BusinessLayer.Abstract;
using OrderSync.DataAccessLayer.Abstract;
using OrderSync.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSync.BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification entity)
        {
            _notificationDal.Add(entity);
        }

		public void TChangeNotificationToFalse(int id)
		{
            _notificationDal.ChangeNotificationToFalse(id);
		}

		public void TChangeNotificationToTrue(int id)
		{
			_notificationDal.ChangeNotificationToTrue(id);
		}

		public void TDelete(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        public List<Notification> TGetAll()
        {
            return _notificationDal.GetAll();
        }

		public List<Notification> TGetAllNotificationByFalse()
		{
			return _notificationDal.GetAllNotificationByFalse();
		}

		public Notification TGetById(int id)
        {
            return _notificationDal.GetById(id);
        }

        public int TNotificationCountByFalseStatus()
        {
            return _notificationDal.NotificationCountByFalseStatus();
        }

        public void TUpdate(Notification entity)
        {
            _notificationDal.Update(entity);
        }
    }
}
