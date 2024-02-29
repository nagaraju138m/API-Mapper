using System.ComponentModel.DataAnnotations;

namespace apiSample.Models
{
    public class group
    {
        [Key] public int groupid { get; set; }
        [Required] public string groupName { get; set; }
        [Required] public string description { get; set; }
        public ICollection<Student> students { get; set; }
    }
}
