using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IJobService
    {
        void JobAdd(Job job);
        void JobDelete(Job job);
        List<Job> GetJobs();
        Job GetJobById(int id);
        Job GetJobByName(string name);

    }
}
