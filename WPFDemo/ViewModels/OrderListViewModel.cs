using System.Collections.ObjectModel;
using System.Windows.Input;
using WPFDemo.Commands.Navigation;
using WPFDemo.Commands.Order;
using WPFDemo.EF.Models;
using WPFDemo.Stores;

namespace WPFDemo.ViewModels
{
    public class OrderListViewModel : ViewModelBase
    {
        public ICommand NavigateToStartCommand { get; set; }
        public ICommand NavigateToAddNewOrderCommand { get; set; }
        public ICommand DeleteOrderCommand { get; set; }
        private ObservableCollection<Order> _orderList = new();
        public ObservableCollection<Order> OrderList
        {
            get => _orderList;
            set
            {
                _orderList = value;
                OnPropertyChanged();
            }
        }
        public OrderListViewModel(NavigationStore navigationStore, ObservableCollection<Order> orderList)
        {
            NavigateToStartCommand = new NavigateToStartCommand(navigationStore);
            DeleteOrderCommand = new DeleteOrderCommand(navigationStore);
            NavigateToAddNewOrderCommand = new NavigateToAddNewOrderCommand(navigationStore);
            OrderList = orderList;
        }
    }
}
