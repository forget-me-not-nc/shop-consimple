using DTO.Models.Orders;

namespace DTO.Response.Orders
{
    public class GetRecentCustomersResponse: PagedResponse
    {
        public List<RecentCustomerModel> Data { get; set; }

        public GetRecentCustomersResponse(List<RecentCustomerModel> customerModels, int pageNumber, int pageSize, int totalPages, int totalRecords)  
        {
            Data = customerModels;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalPages = totalPages;
        }
    }
}
