using EmployeeOrganizer.Model;
using System.Threading.Tasks;

namespace EmployeeOrganizer.UI.Data
{
    public interface IEmployeeDataService
    {
        Task<Employee> GetByIdAsync(int employeeId);
        Task SaveAsync(Employee employee);
    }
}