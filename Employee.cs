using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEnumerableIQueryable
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

    }
}