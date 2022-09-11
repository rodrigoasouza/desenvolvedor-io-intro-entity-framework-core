using Intro.Entity.Framework.Core.Domain.ValueObjetcts;

namespace Intro.Entity.Framework.Core.Domain.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ShippingType Shipping { get; set; }
        public OrderStatus Status { get; set; }
        public string Note { get; set; }
        public ICollection<OrderItem> Itens { get; set; }
    }
}
