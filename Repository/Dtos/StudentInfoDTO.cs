using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Dtos
{
    public class StudentInfoDTO
    {
        public int SId { get; set; }
        public string SName { get; set; }
        public string GroupName { get; set; }
        public List<StudentBookDTO> StudentBooks { get; set; }
    }

    public class StudentBookDTO
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
    }

}
