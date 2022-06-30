using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogWithCategory();
        List<Blog> GetBlogListByWriter(int id);
        List<Blog> GetLast3Blog();
        List<Blog> GetBlogByID(int id);
    }
}
