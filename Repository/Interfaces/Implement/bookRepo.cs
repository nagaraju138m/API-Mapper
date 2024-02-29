using apiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces.Implement
{
    public class bookRepo : GenericRepo<book>, IbookRepo
    {
        private readonly sDbContext context;
        public bookRepo(sDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        //public async Task<bool> isthere(book book)
        //{
        //    var exBook = await context.books.Where(a=> a.bookId)
        //}
    }
}
