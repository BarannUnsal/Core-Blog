using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class NotificationService : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationService(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Add(Notification model)
        {
            _notificationDal.Insert(model);
        }

        public List<Notification> GetAllList()
        {
            return _notificationDal.GetAll();
        }

        public Notification GetById(int id)
        {
            return _notificationDal.GetById(id);
        }

        public void Remove(Notification model)
        {
            _notificationDal.Delete(model);
        }

        public void Update(Notification model)
        {
            _notificationDal.Update(model);
        }
    }
}
