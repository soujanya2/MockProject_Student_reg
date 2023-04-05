using System.ComponentModel.DataAnnotations;

namespace MockProject1.Models
{
    public class Course
    {
        [Key]
        [StringLength(50)]
        public string? CourseName { get; set; }
         public ICollection<Student> students { get; set; } 
    }
}
