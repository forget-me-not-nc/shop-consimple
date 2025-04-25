using Domain.Context;
using Domain.Models;
using DTO.Models.Orders;
using Microsoft.EntityFrameworkCore;
using Repository.Abstract;
using Repository.CustomTypes;

namespace Repository.Concrete
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }

        public async Task<List<Order>> GetOrdersByCustomerId(int customerId)
        {
            return await _shopDbContext.Orders.Where(o => o.ClientId == customerId).ToListAsync();
        }

        public async Task<PagedList<RecentCustomerModel>> GetRecentCusomersPaginatedAsync(int daysThreshold, int pageNumber, int pageSize)
        {
            DateTime timeThreshold = DateTime.UtcNow.AddDays(-daysThreshold);
            
            var query = _shopDbContext.Orders
                .Where(o => o.CreateDate >= timeThreshold)
                .GroupBy(o => new { o.ClientId, o.Customer.FullName })
                .Select(g => new RecentCustomerModel
                {
                    ClientId = g.Key.ClientId,
                    FullName = g.Key.FullName,
                    LastOrderDate = g.Max(o => o.CreateDate)
                })
                .OrderByDescending(c => c.LastOrderDate);

            return await CreateAsync(query, pageNumber, pageSize);
        }
    }
}
