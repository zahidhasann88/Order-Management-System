using Microsoft.EntityFrameworkCore;
using OMSBlazor.Server.Interfaces;
using OMSBlazor.Server.Models;
using OMSBlazor.Shared.Models;

namespace OMSBlazor.Server.Services
{
    public class OrderManager : IOrder
    {
        readonly PostgresContext _dbContext = new();
        public OrderManager(PostgresContext dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all user details
        public List<Order> GetOrderDetails()
        {
            try
            {
                return _dbContext.Orders.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new user record
        public void AddOrderDetails(Order order)
        {
            try
            {
                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar user
        public void UpdateOrderDetails(Order order)
        {
            try
            {
                _dbContext.Entry(order).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular user
        public Order GetOrderData(int id)
        {
            try
            {
                Order? order = _dbContext.Orders.Find(id);
                if (order != null)
                {
                    return order;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular user
        public void DeleteOrder(int id)
        {
            try
            {
                Order? order = _dbContext.Orders.Find(id);
                if (order != null)
                {
                    _dbContext.Orders.Remove(order);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
