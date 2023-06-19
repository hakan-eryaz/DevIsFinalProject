using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using EntityLayer.Concrete.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EFJobRepository:GenericRepository<Job>,IJobDal
    {
        
        public DetailedJobViewModel GetAllInfoAboutJob(int id)
        {
            DetailedJobViewModel model = new DetailedJobViewModel();

            using (var context = new Context())
            {
                model = context.Jobs
                    .Include(x => x.Employer)
                    .Where(x => x.JobID == id)
                    .Select(x => new DetailedJobViewModel
                    {
                        JobID = x.JobID,
                        JobTitle = x.JobTitle,
                        Requirements = x.Requirements,
                        JobCategory = x.JobCategory,
                        Location = x.Location,
                        Employer = x.Employer,
                        Salary = x.Salary,
                        Description = x.Description,
                        ExpirationDate=x.ExpirationDate,
                        PostedDate=x.PostedDate,
                    }).FirstOrDefault();
            }
            return model;
        }

        public List<Job> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Jobs.Include(x=>x.JobCategory).ToList();
            }
        }
    }
}
