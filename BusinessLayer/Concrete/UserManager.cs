using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(User entity)
        {
            throw new NotImplementedException();
        }

        public void TRemove(User entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
