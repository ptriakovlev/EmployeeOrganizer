using Autofac;
using EmployeeOrganizer.UI.ViewModel;

namespace EmployeeOrganizer.UI.Data
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<EmployeeDataService>().As<IEmployeeDataService>();

            return builder.Build();
        }
    }
}
