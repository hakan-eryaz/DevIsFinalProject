using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EmployerSkill
    {
        [Key]
        public int EmployerSkillID { get; set; }
        public int EmployerID { get; set; }
        public int SkillID { get; set; }
    }
}
