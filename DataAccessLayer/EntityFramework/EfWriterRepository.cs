using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public EfWriterRepository(Context context) : base(context)
        {
        }
    }
}
