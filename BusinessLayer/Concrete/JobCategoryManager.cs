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
            _jobCategoryDal.Add(entity);
        }

        public void TRemove(JobCategory entity)
        {
            _jobCategoryDal.Remove(entity);
        }

        public void TUpdate(JobCategory entity)
        {
            _jobCategoryDal.Update(entity);
        }
    }
}
