using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer model)
        {
            _writerDal.Insert(model);
        }

        public List<Writer> GetAllList()
        {
            return _writerDal.GetAll();
        }

        public Writer GetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x => x.WriterID == id);
        }

        public void Remove(Writer model)
        {
            _writerDal.Delete(model);
        }

        public void Update(Writer model)
        {
            _writerDal.Update(model);
        }
    }
}
