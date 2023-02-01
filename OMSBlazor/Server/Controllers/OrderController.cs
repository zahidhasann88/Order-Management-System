using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OMSBlazor.Server.Interfaces;
using OMSBlazor.Shared.Models;

namespace OMSBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _IOrder;
        public OrderController(IOrder iorder)
        {
            _IOrder = iorder;
        }
        [HttpGet]
        public async Task<List<Order>> Get()
        {
            return await Task.FromResult(_IOrder.GetOrderDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Order order = _IOrder.GetOrderData(id);
            if (order != null)
            {
                return Ok(order);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Order order)
        {
            _IOrder.AddOrderDetails(order);
        }
        [HttpPut]
        public void Put(Order order)
        {
            _IOrder.UpdateOrderDetails(order);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IOrder.DeleteOrder(id);
            return Ok();
        }
    }
}
