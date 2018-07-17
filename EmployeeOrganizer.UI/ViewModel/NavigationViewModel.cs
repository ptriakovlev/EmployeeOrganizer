using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using EmployeeOrganizer.Model;
using EmployeeOrganizer.UI.Data;

namespace EmployeeOrganizer.UI.ViewModel
{
    public class NavigationViewModel : INavigationViewModel
    {

        private IEmployeeLookupDataService _employeeLookupService;

        public NavigationViewModel(IEmployeeLookupDataService employeeLookupService)
        {
            _employeeLookupService = employeeLookupService;
            Employees = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _employeeLookupService.GetEmployeeLookupAsync();
            Employees.Clear();
            foreach (var item in lookup)
            {
                Employees.Add(item);
            }
        }

        public ObservableCollection<LookupItem> Employees { get; }


    }
}
