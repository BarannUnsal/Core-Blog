using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public class CommantRepository : IGenericDal<Comment>
    {
        public void Delete(Comment model)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Comment model)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Comment model)
        {
            throw new System.NotImplementedException();
        }
    }
}
