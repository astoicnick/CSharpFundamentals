using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    class Employee
    {
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public Address Address { get; set; }
        public string Title { get; set; }
        public DateTime Birthday { get; set; }
        public decimal HourlyWage { get; set; }
        public int SocialSecurityNumber { get; set; }
        

    }
}
