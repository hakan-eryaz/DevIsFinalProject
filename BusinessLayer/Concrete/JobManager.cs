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
using EntityLayer.Concrete.ViewModels;

namespace BusinessLayer.Concrete
{
    public class JobManager:IJobService
    {
        IJobDal _jobDal;

        public JobManager( IJobDal jobDal)
        {
            _jobDal=jobDal;
        }
        public List<Job> GetJobWithCategory()
        {
            return _jobDal.GetListWithCategory();
        }
        public DetailedJobViewModel GetAllInfoAboutJob(int id)
        {
            return _jobDal.GetAllInfoAboutJob(id);
        }

        public void TAdd(Job entity)
        {
            _jobDal.Add(entity);
        }

        public void TRemove(Job entity)
        {
            _jobDal.Remove(entity);
        }

        public void TUpdate(Job entity)
        {
            _jobDal.Update(entity);
        }

        public List<Job> GetAll()
        {
            return _jobDal.GetAll();
        }

        public Job GetById(int id)
        {
            return _jobDal.Get(id);
        }

        public List<Job> GetJobByID(int id)
        {
            return _jobDal.List(x => x.JobID == id);
        }

        public Job GetJobByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
