using Prism.Events;

namespace EmployeeOrganizer.UI.Event
{
    public class AfterEmployeeSavedEvent:PubSubEvent<AfterEmployeeSavedEventArgs>
    {
    }

    public class AfterEmployeeSavedEventArgs
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
    }
}
