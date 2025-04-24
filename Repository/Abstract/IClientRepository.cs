using Domain.Models;
using Repository.CustomTypes;

namespace Repository.Abstract
{
    public interface IClientRepository
    {
        public Task<List<Client>> GetClientsWithTodaysBirthdaysAsync(DateTime date);
    }
}
