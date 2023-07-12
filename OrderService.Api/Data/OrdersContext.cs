using Microsoft.EntityFrameworkCore;
using OrderService.Api.Models;

namespace OrderService.Api.Data
{
    public class OrdersContext :DbContext
    {
        public DbSet<Order> Orders { get; set; } = null!;
        public OrdersContext(DbContextOptions<OrdersContext> options) : base(options) {}
    }
}
