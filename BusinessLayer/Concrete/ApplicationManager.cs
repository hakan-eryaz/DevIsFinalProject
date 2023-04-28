using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ApplicationManager:IApplicationService
    {
        IApplicationDal _applicationDal;
        public ApplicationManager(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }

        public List<Application> GetAll()
        {
            throw new NotImplementedException();
        }

        public Application GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Application entity)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Application entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Application entity)
        {
            throw new NotImplementedException();
        }
    }
}
