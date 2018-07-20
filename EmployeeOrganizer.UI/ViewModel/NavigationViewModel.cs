using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;
using EmployeeOrganizer.Model;
using EmployeeOrganizer.UI.Data;
using Prism.Events;
using EmployeeOrganizer.UI.Event;
using System;

namespace EmployeeOrganizer.UI.ViewModel
{
    public class NavigationViewModel :ViewModelBase, INavigationViewModel
    {

        private IEmployeeLookupDataService _employeeLookupService;
        private IEventAggregator _eventAggregator;

        public NavigationViewModel(IEmployeeLookupDataService employeeLookupService,
            IEventAggregator eventAggregator)
        {
            _employeeLookupService = employeeLookupService;
            _eventAggregator = eventAggregator;
            Employees = new ObservableCollection<NavigationItemViewModel>();
            _eventAggregator.GetEvent<AfterEmployeeSavedEvent>().Subscribe(AfterEmployeeSaved);
        }

        private void AfterEmployeeSaved(AfterEmployeeSavedEventArgs obj)
        {
            var lookupItem = Employees.Single(l => l.Id == obj.Id);
            lookupItem.DisplayMember = obj.DisplayMember;
        }

        public async Task LoadAsync()
        {
            var lookup = await _employeeLookupService.GetEmployeeLookupAsync();
            Employees.Clear();
            foreach (var item in lookup)
            {
                Employees.Add(new NavigationItemViewModel(item.Id, item.DisplayMember));
            }
        }

        public ObservableCollection<NavigationItemViewModel> Employees { get; }

        private NavigationItemViewModel _selectedEmployee;

        public NavigationItemViewModel SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
                if (_selectedEmployee != null)
                {
                    _eventAggregator.GetEvent<OpenEmployeeDetailViewEvent>()
                        .Publish(_selectedEmployee.Id);
                }
            }
        }



    }
}
