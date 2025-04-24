using Domain.Models.Enums;

namespace Domain.Models
{
    public class Order : BaseEntity
    {
        public string OrderNumber { get; set; }
        public decimal OrderValue { get; set; }
        public SupportedCurrencies Currency { get; set; }

        public int ClientId { get; set; }
        public virtual Client Customer { get; set; }

        public virtual ICollection<OrderProduct> Products {get; set; }
    }
}
