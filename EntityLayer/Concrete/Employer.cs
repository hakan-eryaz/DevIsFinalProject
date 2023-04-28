using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employer
    {
        [Key]
        public int EmployerId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set;}
        public string CompanyEmail { get; set;}
        public string Password { get; set;}
        public string CompanyPhone { get; set;}
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set;}
        public string City { get; set;}
        public string Region { get; set;}
        public string PostalCode { get; set;}
        public string Country { get; set;}
        public int EmployerStatus { get; set; }


    }
}
