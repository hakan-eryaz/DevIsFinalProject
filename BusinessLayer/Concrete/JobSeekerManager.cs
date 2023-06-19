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
        IJobSeekerDal _jobSeekerDal;

        public JobSeekerManager(IJobSeekerDal jobSeekerDal)
        {
            _jobSeekerDal = jobSeekerDal;
        }
        public List<JobSeeker> GetAll()
        {
           return _jobSeekerDal.GetAll();
        }

        public JobSeeker GetById(int id)
        {
            return _jobSeekerDal.Get(id);
        }
        public JobSeeker Login(string email, string password)
        {
            return _jobSeekerDal.Login(email, password);
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

        public JobSeeker GetListWithSkill(int skillId)
        {
            return _jobSeekerDal.GetListWithSkill(skillId);
        }

        public JobSeeker GetByEmailAndPassword(string email, string password)
        {
            return _jobSeekerDal.Login(email, password);
        }

    }
}
