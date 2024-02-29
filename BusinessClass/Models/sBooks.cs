using System.ComponentModel.DataAnnotations.Schema;

namespace apiSample.Models
{
    public class sBooks
    {
        public int Id { get; set; }
        public int sId { get; set; }
        [ForeignKey("sId")]
        public Student Student { get; set; }
        public int bookId { get; set; }
        [ForeignKey("bookId")]
        public book Book { get; set; }
    }
}
