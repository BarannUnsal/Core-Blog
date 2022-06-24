using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);
        List<Category> GetAllCategory();
        Category GetByIdCategory(int id);

    }
}
