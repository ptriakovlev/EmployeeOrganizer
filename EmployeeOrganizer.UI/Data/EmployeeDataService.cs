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

        public async Task<Employee> GetByIdAsync(int employeeId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Employees.AsNoTracking().SingleAsync(f => f.Id == employeeId);
            }

        }

        public async Task SaveAsync(Employee employee)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Employees.Attach(employee);
                ctx.Entry(employee).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
        }
    }
}
