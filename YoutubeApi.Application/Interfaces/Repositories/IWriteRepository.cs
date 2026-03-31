using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class, IEntityBase, new()
    {
        Task Addasync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task HardDeleteAsync(T entity);
        Task AddAsync(Product product);
        Task HardDeleteRangeAsync(IList<T> entity);
        Task UpdateAsync(Task<Product> product);
    }
}
