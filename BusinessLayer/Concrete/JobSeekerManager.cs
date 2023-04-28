using BusinessLayer.Abstract;
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
            throw new NotImplementedException();
        }

        public void TRemove(JobSeeker entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(JobSeeker entity)
        {
            throw new NotImplementedException();
        }
    }
}
