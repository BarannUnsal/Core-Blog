using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var _contact = new Context();
            _contact.Add(blog);
            _contact.SaveChanges();
        }

        public List<Blog> GetAllBlog()
        {
            using var _contact = new Context();
            return _contact.Blogs.ToList();
        }

        public Blog GetByIdBlogy(int id)
        {
            using var _contact = new Context();
            return _contact.Blogs.Find(id);
        }

        public void RemoveBlog(Blog blog)
        {
            using var _contact = new Context();
            _contact.Remove(blog);
            _contact.SaveChanges();
        }

        public void UpdateBlog(Blog blog)
        {
            using var _contact = new Context();
            _contact.Update(blog);
            _contact.SaveChanges();
        }
    }
}
