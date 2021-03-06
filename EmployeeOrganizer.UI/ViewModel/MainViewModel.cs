﻿using EmployeeOrganizer.Model;
using EmployeeOrganizer.UI.Data;
using EmployeeOrganizer.UI.ViewModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace EmployeeOrganizer.UI.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        public INavigationViewModel NavigationViewModel { get; }

        MainViewModel(INavigationViewModel navigationViewModel,
            IEmployeeDetailViewModel employeeDetailViewModel)
        {
            NavigationViewModel = navigationViewModel;
            EmployeeDetailViewModel = employeeDetailViewModel;
        }


        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }

    public IEmployeeDetailViewModel EmployeeDetailViewModel { get; }


    }

    
}
