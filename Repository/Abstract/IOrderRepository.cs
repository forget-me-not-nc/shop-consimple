using Domain.Models;
using DTO.Models.Orders;
using Repository.CustomTypes;

namespace Repository.Abstract
{
    public interface IOrderRepository
    {
        public Task<PagedList<RecentCustomerModel>> GetRecentCusomersPaginatedAsync(int daysThreshold, int pageNumber, int pageSize); 
        public Task<List<Order>> GetOrdersByCustomerId(int customerId);
    }
}
