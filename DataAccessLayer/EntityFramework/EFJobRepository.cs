using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EFJobRepository:GenericRepository<Job>,IJobDal
    {
        public List<Job> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Jobs.Include(x=>x.JobCategory).ToList();
            }
        }
    }
}
