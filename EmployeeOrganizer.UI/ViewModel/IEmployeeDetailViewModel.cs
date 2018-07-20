using System.Threading.Tasks;

namespace EmployeeOrganizer.UI.ViewModel
{
    public interface IEmployeeDetailViewModel
    {
        Task LoadAsync(int EmployeeId);
    }
}