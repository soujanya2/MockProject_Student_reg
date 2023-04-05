using System.ComponentModel.DataAnnotations;

namespace MockProject1.Models
{
    public class Hobby
    {
        [Key]
        [StringLength(20)]
        public string? HobbyName { get; set; } 
        public ICollection<Student> studs { get; set; }
    }
}
