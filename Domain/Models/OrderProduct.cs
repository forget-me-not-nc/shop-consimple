using Domain.Models.Enums;

namespace Domain.Models
{
    public class OrderProduct
    {
        public int ProductId {  get; set; }
        public int OrderId {  get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

        public decimal UnitPrice { get; set; }
        public SupportedCurrencies Currency { get; set; }

        public int Quantity { get; set; }
    }
}
