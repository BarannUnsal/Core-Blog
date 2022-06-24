using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class 
    {
        void Insert(T model);
        void Update(T model);
        void Delete(T model);
        List<T> GetAll();
        T GetById(int id);
    }
}
