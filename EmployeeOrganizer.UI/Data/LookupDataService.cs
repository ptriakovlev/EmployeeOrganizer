using EmployeeOrganizer.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeOrganizer.Model;
using System.Data.Entity;

namespace EmployeeOrganizer.UI.Data
{
    class LookupDataService : IEmployeeLookupDataService
    {
        private Func<EmployeeOrganizerDbContext> _contextCreator;

        public LookupDataService(Func<EmployeeOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetEmployeeLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Employees.AsNoTracking()
                  .Select(f =>
                  new LookupItem
                  {
                      Id = f.Id,
                      DisplayMember = f.FirstName + " " + f.LastName
                  })
                  .ToListAsync();
            }
        }
    }
}
