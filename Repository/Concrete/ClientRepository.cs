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

        public Task<List<Client>> GetClientsWithBirthdaysAsync(DateTime date)
        {
            return _shopDbContext.Clients.Where(c => c.BirthDate.Day == date.Day && c.BirthDate.Month == date.Month).ToListAsync();
        }
    }
}
