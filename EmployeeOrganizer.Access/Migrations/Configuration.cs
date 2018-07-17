namespace EmployeeOrganizer.Access.Migrations
{
    using Model;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeOrganizer.Access.EmployeeOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeOrganizer.Access.EmployeeOrganizerDbContext context)
        {
            context.Employees.AddOrUpdate(
        f => f.FirstName,
        new Employee { FirstName = "Thomas", LastName = "Huber", DateOfEmployment=DateTime.Now },
        new Employee { FirstName = "Urs", LastName = "Meier", DateOfEmployment = DateTime.Now },
        new Employee { FirstName = "Erkan", LastName = "Egin", DateOfEmployment = DateTime.Now },
        new Employee { FirstName = "Sara", LastName = "Huber", DateOfEmployment = DateTime.Now }
        );
        }
    }
}
