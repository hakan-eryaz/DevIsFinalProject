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
    public class JobSeekerManager : IJobSeekerService
    {
        private IJobSeekerDal _jobSeekerDal;

        public JobSeekerManager(IJobSeekerDal jobSeekerDal)
        {
            _jobSeekerDal = jobSeekerDal;
        }
        public List<JobSeeker> GetAll()
        {
            throw new NotImplementedException();
        }

        public JobSeeker GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(JobSeeker entity)
        {
            _jobSeekerDal.Add(entity);
        }

        public void TRemove(JobSeeker entity)
        {
            _jobSeekerDal.Remove(entity);
        }

        public void TUpdate(JobSeeker entity)
        {
            _jobSeekerDal.Update(entity);
        }
    }
}
