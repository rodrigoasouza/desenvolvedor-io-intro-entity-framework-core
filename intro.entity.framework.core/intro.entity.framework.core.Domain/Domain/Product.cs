using Intro.Entity.Framework.Core.Domain.ValueObjetcts;

namespace Intro.Entity.Framework.Core.Domain.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
        public bool Active { get; set; }
    }
}
