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
    }
}
