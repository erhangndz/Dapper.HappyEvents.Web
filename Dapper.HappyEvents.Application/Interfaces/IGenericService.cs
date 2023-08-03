using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.HappyEvents.Application.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T t);
        Task UpdateAsync( T t);
        Task DeleteAsync(int id);
    }
}
