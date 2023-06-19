using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProjectTask
    {
        public int TaskID { get; set; }

        public string TaskName { get; set; }
        public DateTime TaskDeadline { get; set; }

        public int? TaskCreatedBy { get; set; }

        public int? ProjectID { get; set; }
        public Project Project { get; set; }

        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public bool IsEnd { get; set; }

        public bool IsEdited { get; set; }

        public bool IsChecked { get; set; }
    }
}
