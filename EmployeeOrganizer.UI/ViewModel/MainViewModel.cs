using EmployeeOrganizer.Model;
using EmployeeOrganizer.UI.Data;
using FriendOrganizer.UI.ViewModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace EmployeeOrganizer.UI.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        public INavigationViewModel NavigationViewModel { get; set; }

        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            NavigationViewModel = navigationViewModel;
        }


        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }

  
    }

    
}
