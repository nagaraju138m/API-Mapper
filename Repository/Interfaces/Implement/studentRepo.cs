using apiSample.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces.Implement
{
    public class studentRepo : GenericRepo<Student>, iStudent
    {
        public readonly sDbContext context;
        public studentRepo(sDbContext context) : base(context) 
        { 
            this.context = context; 
        }

        public async Task<IEnumerable<Student>> getBygroupid(int id)
        {
            return await context.students.Where(a => a.groupid == id).ToListAsync() ;
        }

        public async Task<StudentInfoDTO> getById(int id)
        {
            var stuinfo = context.students.Where(s => s.sId == id).Select(s => new StudentInfoDTO
            {
                SId = s.sId,
                SName = s.Name,
                GroupName = s.group.groupName,
                StudentBooks = s.StudentBooks.Select(sb => new StudentBookDTO
                {
                    BookId = sb.Book.bookId,
                    BookTitle = sb.Book.title,
                    BookDescription = sb.Book.description
                }).ToList(),
            }).FirstOrDefault();

            //var stuinfo = context.students.Where(s=>s.sId==id)
            //    .Join(
            //            context.sBooks,
            //            student=>student.sId,
            //            sBooks=>sBooks.sId,
            //            (student,stubooks) => new {student,stubooks})
            //    .Join(context.books,
            //    joined=> joined.stubooks.bookId,
            //    book=> book.bookId,
            //    (joined,book) => new StudentInfoDTO
            //    {
            //        SId=joined.student.sId,
            //        SName=joined.student.Name,
            //        GroupName=joined.student.group.groupName,
            //        StudentBooks = new List<StudentBookDTO>
            //        {
            //            new StudentBookDTO
            //            {
            //                BookId=book.bookId,
            //                BookTitle=book.title, BookDescription=book.description,
            //            }
            //        }
            //    } ).FirstOrDefault();

            return stuinfo;
        }
    }
}
