using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private EfCategoryRepository _categoryRepository;

        public CategoryManager(EfCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.Insert(category);
        }

        public List<Category> GetAllCategory()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetByIdCategory(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void RemoveCategory(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
