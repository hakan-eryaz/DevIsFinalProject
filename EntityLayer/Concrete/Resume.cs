using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Resume
    {
        [Key]
        public int ResumeID { get; set; }
        public int JobSeekerID { get; set; }
        public string ResumeTitle { get; set; }
        public byte[] ResumeFile { get; set; }
        public string Position { get; set; }
        public string Level { get; set; }
        public string Experience { get; set; }
        public string Technology { get; set; }
        public string Salary { get; set; }

        public string Way_of_working { get; set; }


        public JobSeeker JobSeeker { get; set; }
    }
}
