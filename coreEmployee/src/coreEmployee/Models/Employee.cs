using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreEmployee.Models
{
    public class Employee
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public DateTime DOB { get; set; }
        public string Role { get; set; }
    }
}
