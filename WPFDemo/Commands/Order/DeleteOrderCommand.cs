using WPFDemo.IoC;
using WPFDemo.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using WPFDemo.Stores;
using WPFDemo.Commands.Navigation;

namespace WPFDemo.Commands.Order
{
    public class DeleteOrderCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        public DeleteOrderCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object? parameter)
        {
            if (parameter != null)
            {
                var orderRepository = ServiceProviderExtensions.ServiceProvider?.GetRequiredService<IOrderRepository>();
                orderRepository?.Delete((Guid)parameter);
                var command = new NavigateToOrderListCommand(_navigationStore);
                command.Execute(null);
            }
        }
    }
}
