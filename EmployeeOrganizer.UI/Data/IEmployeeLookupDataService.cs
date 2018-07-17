using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeOrganizer.Model;

namespace EmployeeOrganizer.UI.Data
{
   public interface IEmployeeLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetEmployeeLookupAsync();
    }
}