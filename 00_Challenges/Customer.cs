using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class Customer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EnrollmentDate { get; set; }
        public int YearsUsingKomodo { get; set; }

        public Customer() { }
        public Customer (int id, string lastName, int age, string enrollmentDate,
            int yearsUsingKomodo)
        {
            ID = id;
            LastName = lastName;
            Age = age;
            EnrollmentDate = enrollmentDate;
            YearsUsingKomodo = yearsUsingKomodo;
        }


    }
}
