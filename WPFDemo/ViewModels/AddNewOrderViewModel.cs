using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Extensions.DependencyInjection;
using WPFDemo.Commands.Navigation;
using WPFDemo.Commands.Order;
using WPFDemo.EF.Models;
using WPFDemo.IoC;
using WPFDemo.Repository.Interfaces;
using WPFDemo.Stores;

namespace WPFDemo.ViewModels
{
    public class AddNewOrderViewModel : ViewModelBase, IDataErrorInfo
    {
        public ICommand NavigateToOrderListCommand { get; set; }
        public ICommand CreateNewOrderCommand { get; set; }

        public AddNewOrderViewModel(NavigationStore navigationStore)
        {
            var orderRepository = ServiceProviderExtensions.ServiceProvider?.GetRequiredService<IOrderRepository>();
            NavigateToOrderListCommand = new NavigateToOrderListCommand(navigationStore);
            CreateNewOrderCommand = new CreateNewOrderCommand(navigationStore, this);
            Order = new Order();
        }

        private Order _order = new();
        public Order Order
        {
            get => _order;
            set
            {
                _order = value;
            }
        }

        public Guid CustomerId
        {
            get => _order.CustomerId;
            set
            {
                if (_order.CustomerId != value)
                {
                    _order.CustomerId = value;
                    OnPropertyChanged(nameof(CustomerId));
                }
            }
        }

        public decimal TotalAmount
        {
            get => _order.TotalAmount;
            set
            {
                if (_order.TotalAmount != value)
                {
                    _order.TotalAmount = value;
                    OnPropertyChanged(nameof(TotalAmount));
                }
            }
        }

        public string OrderStatus
        {
            get => _order.OrderStatus;
            set
            {
                if (_order.OrderStatus != value)
                {
                    _order.OrderStatus = value;
                    OnPropertyChanged(nameof(OrderStatus));
                }
            }
        }

        public string ShippingAddress
        {
            get => _order.ShippingAddress;
            set
            {
                if (_order.ShippingAddress != value)
                {
                    _order.ShippingAddress = value;
                    OnPropertyChanged(nameof(ShippingAddress));
                }
            }
        }

        public string Error
        {
            get
            {
                string error = $"{this[nameof(CustomerId)]}{this[nameof(TotalAmount)]}{this[nameof(OrderStatus)]}{this[nameof(ShippingAddress)]}";

                return string.IsNullOrEmpty(error) ? string.Empty : error;
            }
        }

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                switch (columnName)
                {
                    case nameof(CustomerId):
                        if (_order.CustomerId == Guid.Empty)
                        {
                            result = "Customer Id must be provided.";
                        }
                        break;
                    case nameof(TotalAmount):
                        if (_order.TotalAmount <= 0)
                        {
                            result = "Total amount is required and must be greater than 0.";
                        }
                        break;
                    case nameof(OrderStatus):
                        if (string.IsNullOrWhiteSpace(_order.OrderStatus))
                        {
                            result = "Order status cannot be empty.";
                        }
                        break;
                    case nameof(ShippingAddress):
                        if (string.IsNullOrWhiteSpace(_order.ShippingAddress))
                        {
                            result = "Shipping address cannot be empty.";
                        }
                        break;
                }
                return result;
            }
        }
    }
}
