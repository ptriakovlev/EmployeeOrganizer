using EmployeeOrganizer.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmployeeOrganizer.Access
{
    public class EmployeeOrganizerDbContext : DbContext
    {
        public EmployeeOrganizerDbContext() : base("EmployeeOrganizerDb")
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
