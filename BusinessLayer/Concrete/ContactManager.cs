using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public void Add(Contact model)
        {
            contactDal.Insert(model);
        }

        public List<Contact> GetAllList()
        {
            return contactDal.GetAll();
        }

        public Contact GetById(int id)
        {
            return contactDal.GetById(id);
        }

        public void Remove(Contact model)
        {
            contactDal.Delete(model);
        }

        public void Update(Contact model)
        {
            contactDal.Update(model);
        }
    }
}
