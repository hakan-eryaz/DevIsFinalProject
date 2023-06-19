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
using EntityLayer.Concrete.ViewModels;

namespace DataAccessLayer.EntityFramework
{
    public class EfApplicationRepository : GenericRepository<Application>, IApplicationDal
    {
        
        public List<ApplicationViewModel> GetApplications()
        {
            List<ApplicationViewModel> model = new List<ApplicationViewModel>();

            using (var context = new Context())
            {
                model = context.Applications
                    .Include(x => x.Job)
                    .Include(x => x.JobSeeker)
                    .ThenInclude(x => x.Skills)
                    .Select(x => new ApplicationViewModel
                    {
                        ApplicationID = x.ApplicationID,
                        JobID = x.JobID,
                        JobSeekerID = x.JobSeekerID,
                        ApplicationDate = x.ApplicationDate,
                        ApplicantName = x.JobSeeker.FirstName + " " + x.JobSeeker.LastName,
                        JobName = x.Job.JobTitle,
                        SkillNames = x.JobSeeker.Skills.Select(s => s.Skill.SkillName).ToList(),
                        Requirement = x.Job.Requirements,
                        JobCategory = x.Job.JobCategory.CategoryName,
                        JobSeekerLocation = x.JobSeeker.City,
                        JobLocation = x.Job.Location,
                        ApplicationStatus = x.ApplicationStatus

                    })
                    .ToList();
            }
            return model;
        }

        public ApplicationViewModel GetApplicationsByID(int id)
        {
            ApplicationViewModel model = new ApplicationViewModel();

            using (var context = new Context())
            {
                model = context.Applications
                    .Include(x => x.Job)
                    .Include(x => x.JobSeeker)
                    .ThenInclude(x => x.Skills).Where(x => x.ApplicationID == id)
                    .Select(x => new ApplicationViewModel
                    {
                        ApplicationID = x.ApplicationID,
                        JobID = x.JobID,
                        JobSeekerID = x.JobSeekerID,
                        ApplicationDate = x.ApplicationDate,
                        ApplicantName = x.JobSeeker.FirstName + " " + x.JobSeeker.LastName,
                        JobName = x.Job.JobTitle,
                        SkillNames = x.JobSeeker.Skills.Select(s => s.Skill.SkillName).ToList(),
                        Requirement = x.Job.Requirements,
                        JobCategory = x.Job.JobCategory.CategoryName,
                        JobSeekerLocation = x.JobSeeker.City,
                        JobLocation = x.Job.Location,
                        ApplicationStatus = x.ApplicationStatus,
                        Resumes = x.JobSeeker.Resumes,
                        ApplicantMail = x.JobSeeker.Email,
                        ApplicantContactNumber = x.JobSeeker.ContactNumber,
                        ApplicantAddress=x.JobSeeker.Address,
                        ApplicantCity=x.JobSeeker.City,
                        Employer=x.Job.Employer,
                        JobSalary=x.Job.Salary,
                        Description=x.Job.Description


                    }).FirstOrDefault();
            }
            return model;
        }
    }
}
