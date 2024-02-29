using apiSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces.Implement
{
    public class groupRepo : GenericRepo<group>, IgroupRepo
    {
        private readonly sDbContext context;
        public groupRepo(sDbContext _context) : base(_context)
        {
            this.context = _context;
        }

        public async Task<IEnumerable<Student>> getbyGroupid(int groupid)
        {
            List<Student> students = new List<Student>();

            students = await context.students.Where(a => a.groupid == groupid).ToListAsync();
            return students;
        }
    }
}
