using WPFDemo.Stores;
using WPFDemo.ViewModels;

namespace WPFDemo.Commands.Navigation
{
    public class NavigateToAddNewOrderCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToAddNewOrderCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new AddNewOrderViewModel(_navigationStore);
        }
    }
}
