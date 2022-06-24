using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        private Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public List<Category> GetAllCategory()
        {
            return _context.Categories.ToList();
        }

        public Category GetByIdCategory(int id)
        {
            return _context.Categories.Find(id);
        }

        public void RemoveCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }
    }
}
