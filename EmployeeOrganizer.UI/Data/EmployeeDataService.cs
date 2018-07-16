using EmployeeOrganizer.Model;
using System.Collections.Generic;

namespace EmployeeOrganizer.UI.Data
{
    public class EmployeeDataService : IEmployeeDataService
    {
        public IEnumerable<Employee> GetAll()
        {
            // TODO: Load data from real database
            yield return new Employee { FirstName = "Thomas", LastName = "Huber" };
            yield return new Employee { FirstName = "Andreas", LastName = "Boehler" };
            yield return new Employee { FirstName = "Julia", LastName = "Huber" };
            yield return new Employee { FirstName = "Chrissi", LastName = "Egin" };

        }
    }
}
