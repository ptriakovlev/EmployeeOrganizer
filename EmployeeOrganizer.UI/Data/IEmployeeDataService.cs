using System.Collections.Generic;
using EmployeeOrganizer.Model;

namespace EmployeeOrganizer.UI.Data
{
    public interface IEmployeeDataService
    {
        IEnumerable<Employee> GetAll();
    }
}