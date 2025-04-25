namespace DTO.Requests.Orders
{
    public class GetRecentCustomersRequest: PagedRequest
    {
        public int DaysThreshold { get; set; }
    }
}