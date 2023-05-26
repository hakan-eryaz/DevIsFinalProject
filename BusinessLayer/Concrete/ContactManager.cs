using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void TRemove(Contact entity)
        {
            _contactDal.Remove(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
