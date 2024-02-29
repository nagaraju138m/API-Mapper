using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        Task<T> CreateAsync(T item);
        Task UpdateAsync(T item);
        Task<T> DeleteAsync(T item);
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> Exists(int id);
    }
}
