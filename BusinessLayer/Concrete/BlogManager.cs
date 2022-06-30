using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
         
        public List<Blog> GetListWithCategoryByWriterBm()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetAll().TakeLast(3).ToList();
        }

        public void Add(Blog model)
        {
            _blogDal.Insert(model);
        }

        public void Remove(Blog model)
        {
            _blogDal.Delete(model);
        }

        public void Update(Blog model)
        {
            _blogDal.Update(model);
        }

        public List<Blog> GetAllList()
        {
            return _blogDal.GetAll();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }
    }
}
