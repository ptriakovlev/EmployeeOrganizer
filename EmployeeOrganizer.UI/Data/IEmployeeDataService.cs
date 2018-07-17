using System.Collections.Generic;
using EmployeeOrganizer.Model;
using System.Threading.Tasks;

namespace EmployeeOrganizer.UI.Data
{
    public interface IEmployeeDataService
    {
        Task<List<Employee>> GetAllAsync();
    }
}