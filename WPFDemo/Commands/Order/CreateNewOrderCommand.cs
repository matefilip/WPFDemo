using WPFDemo.Commands.Navigation;
using WPFDemo.IoC;
using WPFDemo.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using WPFDemo.Stores;
using WPFDemo.ViewModels;

namespace WPFDemo.Commands.Order
{
    public class CreateNewOrderCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        private readonly AddNewOrderViewModel _viewModel;
        public CreateNewOrderCommand(NavigationStore navigationStore, AddNewOrderViewModel viewModel)
        {
            _navigationStore = navigationStore;
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            if (string.IsNullOrEmpty(_viewModel.Error) && parameter != null)
            {
                var orderRepository = ServiceProviderExtensions.ServiceProvider?.GetRequiredService<IOrderRepository>();
                EF.Models.Order order = (EF.Models.Order)parameter;
                order.Id = Guid.NewGuid();
                order.OrderDate = DateTime.Now;
                orderRepository?.Add(order);
                var command = new NavigateToOrderListCommand(_navigationStore);
                command.Execute(null);
            }
        }
    }
}
