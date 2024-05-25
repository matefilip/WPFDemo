using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;
using WPFDemo.Commands.Navigation;
using WPFDemo.IoC;
using WPFDemo.Repository.Interfaces;
using WPFDemo.Stores;

namespace WPFDemo.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        public ICommand NavigateToOrderListCommand { get; set; }

        public StartViewModel(NavigationStore navigationStore)
        {
            var orderRepository = ServiceProviderExtensions.ServiceProvider?.GetRequiredService<IOrderRepository>();
            NavigateToOrderListCommand = new NavigateToOrderListCommand(navigationStore);
        }
    }
}
