using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Dtos
{
    public class bookDto
    {
        public int bookId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
