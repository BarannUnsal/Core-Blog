using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category model)
        {
            _categoryDal.Insert(model);
        }
        public List<Category> GetAllList()
        {
            return _categoryDal.GetAll(); 
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public void Remove(Category model)
        {
            _categoryDal.Delete(model);
        }

        public void Update(Category model)
        {
            _categoryDal.Update(model);
        }
    }
}
