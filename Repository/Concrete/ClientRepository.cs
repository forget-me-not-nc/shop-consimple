using Domain.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Abstract;

namespace Repository.Concrete
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        public ClientRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }

        public Task<List<Client>> GetClientsWithTodaysBirthdaysAsync(DateTime date)
        {
            return _shopDbContext.Clients.Where(c => c.BirthDate.Date == date.Date).ToListAsync();
        }
    }
}
