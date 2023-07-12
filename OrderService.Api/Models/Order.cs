using System.ComponentModel.DataAnnotations;

namespace OrderService.Api.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        [Required] 
        public Sender? Sender { get; set; }
        [Required] 
        public Recipient? Recipient { get; set; }
        [Required][Range(0, Double.MaxValue, ErrorMessage = "Вес не может быть отрицательным")] 
        public double? Weight { get; set; }
        public DateTime Created { get; set; } 
    }
}
