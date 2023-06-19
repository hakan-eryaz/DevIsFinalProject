using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        public int ProjectID { get; set; }

        public string ProjectName { get; set; }

        public string ProjectDesc { get; set; }
        public string ProjectBrief { get; set; }
        public DateTime ProjectDeadline { get; set; }

        public int? ProjectManagerID { get; set; }
        public Employee ProjectManager { get; set; }

        public ICollection<ProjectTask> ProjectTasks { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public bool IsEdited { get; set; }

        public bool IsChecked { get; set; }
    }
}
