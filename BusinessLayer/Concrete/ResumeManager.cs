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
    public class ResumeManager : IResumeService
    {
        private IResumeDal _resumeDal;

        public ResumeManager(IResumeDal resumeDal)
        {
            _resumeDal = resumeDal;
        }
        public List<Resume> GetAll()
        {
            throw new NotImplementedException();
        }

        public Resume GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Resume entity)
        {
            _resumeDal.Add(entity);
        }

        public void TRemove(Resume entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Resume entity)
        {
            throw new NotImplementedException();
        }
    }
}
