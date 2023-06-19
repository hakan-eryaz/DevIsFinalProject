using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ViewModels
{
    public class ApplicationViewModel
    {
        public int ApplicationID { get; set; }
        public int JobID { get; set; }
        public int JobSeekerID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public List<string> SkillNames { get; set; }
        public string ApplicantName { get; set; }
        public string JobName { get; set; }
        public string Description { get; set; }

        public string Requirement { get; set; }
        public string JobCategory { get; set; }
        public string JobSeekerLocation { get; set; }
        public string JobLocation { get; set; }
        public int ApplicationStatus { get; set; }
        public ICollection<Resume> Resumes { get; set; }
        public string ApplicantMail { get; set; }
        public string ApplicantAddress { get; set; }
        public string ApplicantContactNumber { get; set; }
        public string ApplicantCity { get; set; }
        public Employer Employer { get; set; }
        public decimal JobSalary { get; set; }


    }
}
