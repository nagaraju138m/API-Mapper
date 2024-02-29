using apiSample.Models;
using Repository.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface iStudent : IGenericRepo<Student>
    {
        Task<IEnumerable<Student>> getBygroupid(int id);
        Task<StudentInfoDTO> getById(int id);
    }
}
