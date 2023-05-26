using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DevIsFinalProjectDB;integrated security=true;");
        }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<EmployerSkill> EmployerSkills { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobSeekerSkill> JobSeekerSkills { get; set;}
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
