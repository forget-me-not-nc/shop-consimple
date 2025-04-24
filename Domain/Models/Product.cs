using Domain.Models.Enums;

namespace Domain.Models
{
    public class Product : BaseEntity
    {
        public string ProductTitle { get; set; }
        public string ProductDeclarationName { get; set; }
        public decimal Price {  get; set; }
        public SupportedCurrencies Currency {  get; set; }
        public string SKU {  get; set; }

        public int CategoryId {  get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<OrderProduct> Orders { get; set; }
    }
}
