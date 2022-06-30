using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T model);
        void Remove(T model);
        void Update(T model);
        List<T> GetAllList(); 
        T GetById(int id);
    }
}
