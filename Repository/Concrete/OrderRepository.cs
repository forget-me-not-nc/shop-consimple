using Domain.Context;
using Repository.Abstract;

namespace Repository.Concrete
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }
    }
}
