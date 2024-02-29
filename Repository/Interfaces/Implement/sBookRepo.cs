using apiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces.Implement
{
    public class sBookRepo : GenericRepo<sBooks>, IsBookRepo
    {
        private readonly sDbContext context;
        public sBookRepo(sDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public async Task<bool> isExist(sBooks book)
        {
            var res = context.sBooks.Where(a => a.sId == book.sId & a.bookId == book.bookId);
            if (res.Any())
            {
                return true;
            }
            return false;
        }
    }
}
