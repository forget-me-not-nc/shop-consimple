using Domain.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.CustomTypes;
using System.Drawing.Printing;

namespace Repository.Concrete
{
    public class BaseRepository
    {
        protected readonly ShopDbContext _shopDbContext;

        public BaseRepository(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        protected async Task<PagedList<T>> CreateAsync<T>(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PagedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
