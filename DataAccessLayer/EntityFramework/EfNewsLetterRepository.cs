using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfNewsLetterRepository : GenericRepository<NewsLetter>, INewsLetterDal
    {
        public EfNewsLetterRepository(Context context) : base(context)
        {
        }
    }
}
