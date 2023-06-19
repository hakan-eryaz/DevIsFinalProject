using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.ViewModels
{
    public class DetailedJobViewModel
    {
        public int JobID { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int JobStatus { get; set; }
        public int EmployerID { get; set; }
        public int CategoryID { get; set; }
        public Employer Employer { get; set; }
        public JobCategory JobCategory { get; set; }

    }
}
