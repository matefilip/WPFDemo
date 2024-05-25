using WPFDemo.Stores;
using WPFDemo.ViewModels;

namespace WPFDemo.Commands.Navigation
{
    public class NavigateToStartCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToStartCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new StartViewModel(_navigationStore);
        }
    }
}
