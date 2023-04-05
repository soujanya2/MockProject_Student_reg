using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace MockProject1.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [MinimumAge(18, ErrorMessage = "Minimum required age should be 18")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        [Display(Name = "Course")]
        public string? CourseName { get; set; }

        [ForeignKey("CourseName")]
        public Course? Courses { get; set; }


        [Display(Name = "Hobbies")]
        public string? HobbiesName { get; set; }

        [ForeignKey("HobbiesName")]
        public Hobby? Hobbie { get; set; }
    }
}
