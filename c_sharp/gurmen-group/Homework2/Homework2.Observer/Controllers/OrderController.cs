using Homework2.Observer.Models;
using Homework2.Observer.Obsorver;
using Homework2.Observer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.Observer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderContext _orderContext;

        public OrderController(IOrderRepository orderRepository, OrderContext orderContext)
        {
            _orderRepository = orderRepository;
            _orderContext = orderContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = _orderRepository.GetAll();

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
           var data = _orderRepository.Save(order);

            _orderContext.RunObservers(order);

            return Ok(data);
        }
    }
}

