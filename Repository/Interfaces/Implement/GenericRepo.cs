using apiSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces.Implement
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly sDbContext context;

        public GenericRepo(sDbContext _context)
        {
            this.context = _context;
        }

        public async Task<T> CreateAsync(T item)
        {
            await context.AddAsync(item);
            await context.SaveChangesAsync();
            return item;
        }

        public async Task<T> DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            this.context.Remove(id);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var res = await context.Set<T>().FindAsync(id) != null;
            context.SaveChanges();
            if (res)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var results= await context.Set<T>().ToListAsync();
            return results;
        }

        public async Task<T> GetAsync(int id)
        {
            var result = await context.Set<T>().FindAsync(id);
            if (result != null)
            {
                return result;
            }
            throw new DirectoryNotFoundException();
        }

        public async Task UpdateAsync(T item)
        {
            this.context.Set<T>().Update(item);
            await context.SaveChangesAsync();
        }
    }
}
