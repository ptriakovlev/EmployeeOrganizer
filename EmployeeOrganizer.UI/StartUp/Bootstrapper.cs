using Autofac;
using EmployeeOrganizer.Access;
using EmployeeOrganizer.UI.ViewModel;

namespace EmployeeOrganizer.UI.Data
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EmployeeOrganizerDbContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();

            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<EmployeeDataService>().As<IEmployeeDataService>();

            return builder.Build();
        }
    }
}
