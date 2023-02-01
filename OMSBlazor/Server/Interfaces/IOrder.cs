using OMSBlazor.Shared.Models;

namespace OMSBlazor.Server.Interfaces
{
    public interface IOrder
    {
        public List<Order> GetOrderDetails();
        public void AddOrderDetails(Order order);
        public void UpdateOrderDetails(Order order);
        public Order GetOrderData(int id);
        public void DeleteOrder(int id);
    }
}
