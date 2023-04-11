using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class JobManager:IJobService
    {
        private IJobDal _jobDal;

        public JobManager( IJobDal jobDal)
        {
            _jobDal=jobDal;
        }
        public void JobAdd(Job job)
        {
            _jobDal.Add(job);
        }

        public void JobDelete(Job job)
        {
            _jobDal.Remove(job);
        }

        public List<Job> GetJobs()
        {
            return _jobDal.GetAll();
        }

        public Job GetJobById(int id)
        {
            return _jobDal.Get(id);
        }

        public Job GetJobByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
