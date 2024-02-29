using System.ComponentModel.DataAnnotations;

namespace apiSample.Models
{
    public class book
    {
        [Key] public int bookId { get; set; }
        [Required] public string title { get; set; }
        [Required] public string description { get; set; }
        public ICollection<sBooks> books { get; set; }
    }
}
