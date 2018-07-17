using EmployeeOrganizer.Access;
using EmployeeOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizer.UI.Data
{
    public class EmployeeDataService : IEmployeeDataService
    {

        private Func<EmployeeOrganizerDbContext> _contextCreator;

        public EmployeeDataService(Func<EmployeeOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Employees.AsNoTracking().ToListAsync();
            }

        }
    }
}
