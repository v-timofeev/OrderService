using System.ComponentModel.DataAnnotations;

namespace OrderService.Api.Models
{
    public class Person
    {
        [Required] public string? FullName { get; set; }
        [Required] public string? FullAddress { get; set; }
    }
}
