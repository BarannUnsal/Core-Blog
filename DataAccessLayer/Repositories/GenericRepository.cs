using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T model)
        {
            _context.Remove(model);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T model)
        {
            _context.Add(model);
            _context.SaveChanges();
        }

        public void Update(T model)
        {
            _context.Update(model);
            _context.SaveChanges();
        }
    }
}
