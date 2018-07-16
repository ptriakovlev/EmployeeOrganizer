using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOrganizer.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfEmployment { get; set; }

        public int Group { get; set; }

        public float BasicWageRate { get; set; }

        public int BossId { get; set; }
        

    }
}
