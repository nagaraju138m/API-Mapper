using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiSample.Models
{
    public class Student
    {
        [Key] public int sId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int Age { get; set; }
        [Required] public string city { get; set; }
        [Required] public int groupid { get; set; }
        [ForeignKey("groupid")]
        public group group { get; set; }
        public ICollection<sBooks> StudentBooks { get; set; }
    }
}
