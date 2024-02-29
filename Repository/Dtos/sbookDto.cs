using apiSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Dtos
{
    public class sbookDto
    {
        public int Id { get; set; }
        public int sId { get; set; }
        public int bookId { get; set; }
    }
}
