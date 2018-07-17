using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeOrganizer.Model
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime DateOfEmployment { get; set; }

        public int Group { get; set; }

        public float BasicWageRate { get; set; }

        public int BossId { get; set; }
        

    }
}
