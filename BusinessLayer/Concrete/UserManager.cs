using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal=userDal;
        }
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
            _userDal.Add(entity);
        }

        public void TRemove(User entity)
        {
            _userDal.Remove(entity);
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
