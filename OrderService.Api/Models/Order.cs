using System.Diagnostics.CodeAnalysis;

namespace OrderService.Api.Models
{
    public class Order
    {
        public Guid Id { get; set; } 
        public Person? Sender { get; set; }
        public Address? From { get; set; }
        public Person? Recipient { get; set; }
        public Address? To { get; set; }
        public double Weight { get; set; }
        public DateTime Created { get; set; } 
        /*
         * - api метод создания заказа: guid CreateOrder(Order order)
          Заказ (Order) должен содержать 
            адрес / фио отправителя, 
            адрес / фио получателя, 
            вес груза.
          помимо этих полей для заказа должен генерировать автоматически сгенерированный номер заказа (guid) и текущая дата 
          - api метод для просмотра заказа по номеру (guid)
          - api метод для просмотра всех созданных заказов
         */
    }
}
