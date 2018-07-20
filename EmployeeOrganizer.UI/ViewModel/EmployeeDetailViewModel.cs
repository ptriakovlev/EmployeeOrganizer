using EmployeeOrganizer.Model;
using EmployeeOrganizer.UI.Data;
using EmployeeOrganizer.UI.Event;
using Prism.Events;
using System.Threading.Tasks;
using System;
using System.Windows.Input;
using Prism.Commands;
using EmployeeOrganizer.UI.Wrapper;

namespace EmployeeOrganizer.UI.ViewModel
{
    public class EmployeeDetailViewModel : ViewModelBase, IEmployeeDetailViewModel
    {
        private IEmployeeDataService _dataService;
        private IEventAggregator _eventAggregator;

        public EmployeeDetailViewModel(IEmployeeDataService dataService,
            IEventAggregator eventAggregator)
        {
            _dataService = dataService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenEmployeeDetailViewEvent>()
                .Subscribe(OnOpenEployeeDetailedView);

            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
        }
        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync(Employee.);
            _eventAggregator.GetEvent<AfterEmployeeSavedEvent>().Publish(
                new AfterEmployeeSavedEventArgs
                {
                    Id = Employee.Id,
                    DisplayMember = $"{Employee.FirstName} {Employee.LastName}"
                });
        }

        private bool OnSaveCanExecute()
        {
            //TODO: Check if employee is valid 
            return true;
        }

        private async void OnOpenEployeeDetailedView(int friendId)
        {
            await LoadAsync(friendId);
        }

        public async Task LoadAsync(int EmployeeId)
        {
            var employee = await _dataService.GetByIdAsync(EmployeeId);
            Employee = new EmployeeWrapper(employee);
        }

        private EmployeeWrapper _Employee;

        public EmployeeWrapper Employee
        {
            get { return _Employee; }
            private set
            {
                _Employee = value;
                OnPropertyChanged();
            }
        }
        public ICommand SaveCommand { get; }
    }
}
