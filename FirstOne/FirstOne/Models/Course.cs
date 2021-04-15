using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstOne.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        [Range(1, 20)]
        public int Credits { get; set; }

        [Display(Name = "Student Count")]
        [NotMapped]
        public int EnrollmentCount { get => Enrollments?.Count ?? 0; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
