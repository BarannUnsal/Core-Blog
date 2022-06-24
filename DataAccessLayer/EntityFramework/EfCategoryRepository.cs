using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryRepository(Context context) : base(context)
        {
        }
    }
}
