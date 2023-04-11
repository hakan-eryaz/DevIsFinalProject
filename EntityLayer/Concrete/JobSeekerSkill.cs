using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class JobSeekerSkill
    {
        [Key]
        public int JobSeekerSkillID { get; set; }
        public int JobSeekerID { get; set; }
        public int SkillID { get; set; }
        public JobSeeker JobSeeker { get; set; }
        public Skill Skill { get; set; }

    }
}
