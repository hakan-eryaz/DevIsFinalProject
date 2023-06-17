using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
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
        public string Requirement { get; set; }
        public string JobCategory { get; set; }
        public string JobSeekerLocation { get; set; }
        public string JobLocation { get; set; }
        public int ApplicationStatus { get; set; }


    }
}
