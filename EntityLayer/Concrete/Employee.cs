using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeUserID { get; set; }

        public string EmployeeEmail { get; set; }

        public string EmployeePassword { get; set; }

        public string EmployeeCurrentPassword { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeSurname { get; set; }
        public string EmployeeNameSurname { get; set; }
        public DateTime EmployeeDateOfBirth { get; set; }

        public string EmployeePhoneNumber { get; set; }
        public string EmployeeRole { get; set; }


        public string Department { get; set; }

        public int? ProjectID { get; set; }
        public Project Project { get; set; }

        public ICollection<ProjectTask> ProjectTasks { get; set; }

        public bool IsDepartmentManager { get; set; }

        public bool IsProjectManager { get; set; }

        public bool IsEdited { get; set; }

        public bool IsChecked { get; set; }
    }
}