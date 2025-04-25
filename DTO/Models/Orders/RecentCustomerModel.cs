namespace DTO.Models.Orders
{
    public class RecentCustomerModel
    {
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public DateTime LastOrderDate { get; set; }
    }
}
