using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Api.Data;
using OrderService.Api.Models;

namespace OrderService.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersContext _context;

        public OrdersController(OrdersContext context)
        {
            _context = context;
        }

        // GET: api/v1/orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            if (_context.Orders == null)
            {
                return NotFound();
            }
            return await _context.Orders.ToListAsync();
        }

        // GET: api/v1/orders/13d8eeaa-e68c-4857-91be-2e59a2916d38
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(Guid id)
        {
            if (_context.Orders == null)
            {
                return NotFound();
            }
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // POST: api/v1/orders
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateOrder([FromBody] Order order)
        {
            if (_context.Orders == null)
            {
                  return Problem("Entity set 'OrdersContext.Orders'  is null.");
            }
            order.Id = new Guid();
            order.Created = DateTime.Now;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetOrder", new { id = order.Id }, order.Id);
        }
    }
}
