using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message model)
        {
            _messageDal.Insert(model);
        }

        public List<Message> GetAllList()
        {
            return _messageDal.GetAll();
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.GetListAll(x => x.Receiver == p);
        }

        public void Remove(Message model)
        {
            _messageDal.Delete(model);
        }

        public void Update(Message model)
        {
            _messageDal.Update(model);
        }
    }
}
