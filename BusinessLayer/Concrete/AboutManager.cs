using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About model)
        {
            throw new System.NotImplementedException();
        }

        public List<About> GetAllList()
        {
            throw new System.NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.GetAll();
        }

        public void Remove(About model)
        {
            throw new System.NotImplementedException();
        }

        public void Update(About model)
        {
            throw new System.NotImplementedException();
        }
    }
}