using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfJobSeekerRepository : GenericRepository<JobSeeker>, IJobSeekerDal
    {
        public JobSeeker GetListWithSkill(int id)
        {
            using (var c = new Context())
            {
                JobSeeker person = c.JobSeekers
                    .Include(p => p.Skills)
                    .ThenInclude(ps => ps.Skill).Include(res=>res.Resumes)
                    .FirstOrDefault(p => p.JobSeekerID == id);

                
                return person;
            }
        }

        public JobSeeker Login(string email, string password)
        {
            using var context = new Context();
            return context.Set<JobSeeker>().FirstOrDefault(e => e.Email == email && e.Password == password);
        }
    }
    }

