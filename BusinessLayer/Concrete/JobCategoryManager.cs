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
    public class JobCategoryManager : IJobCategoryService
    {
        private IJobCategoryDal _jobCategoryDal;

        public JobCategoryManager(IJobCategoryDal jobCategoryDal)
        {
               _jobCategoryDal= jobCategoryDal;
        }
        public List<JobCategory> GetAll()
        {
            return _jobCategoryDal.GetAll();
        }

        public JobCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(JobCategory entity)
        {
            throw new NotImplementedException();
        }

        public void TRemove(JobCategory entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(JobCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
