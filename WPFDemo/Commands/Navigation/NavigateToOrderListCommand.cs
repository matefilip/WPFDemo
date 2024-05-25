using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using WPFDemo.IoC;
using WPFDemo.Repository.Interfaces;
using WPFDemo.Stores;
using WPFDemo.ViewModels;

namespace WPFDemo.Commands.Navigation
{
    public class NavigateToOrderListCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToOrderListCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            var orderRepository = ServiceProviderExtensions.ServiceProvider?.GetRequiredService<IOrderRepository>();
            var orderList = orderRepository?.GetAll();
            if (orderList != null)
            {
                var observableList = new ObservableCollection<EF.Models.Order>(orderList);
                _navigationStore.CurrentViewModel = new OrderListViewModel(_navigationStore, observableList);
            }
        }
    }
}
