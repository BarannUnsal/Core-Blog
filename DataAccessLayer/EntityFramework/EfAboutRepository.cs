using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
        public EfAboutRepository(Context context) : base(context)
        {
        }
    }
}
