using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IJobService:IGenericService<Job>
    {
        Job GetJobByName(string name);
        List<Job> GetJobWithCategory();
        List<Job> GetJobByID(int id);


    }
}
