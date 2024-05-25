using WPFDemo.EF.Models;

namespace WPFDemo.Repository.Interfaces
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAll();
        public void Add(Order order);
        public void Delete(Guid Id);
    }
}
