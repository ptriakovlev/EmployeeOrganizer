using EmployeeOrganizer.Model;
using EmployeeOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeOrganizer.UI.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        private IEmployeeDataService _friendDataService;
        private Employee _SelectedEmployee;

        public MainViewModel(IEmployeeDataService friendDataService)
        {
            Employees = new ObservableCollection<Employee>();
            _friendDataService = friendDataService;
        }
        public ObservableCollection<Employee> Employees { get; set; }

        public void Load()
        {
            var eployees = _friendDataService.GetAll();
            Employees.Clear();
            foreach (var employee in eployees)
            {
                Employees.Add(employee);
            }
        }

        public Employee SelectedEmployee
        {
            get { return _SelectedEmployee; }
            set
            { _SelectedEmployee = value;
                OnPropertyChanged();
            }
        }
    }

    
}
