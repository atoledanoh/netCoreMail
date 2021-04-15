using System.ComponentModel.DataAnnotations;

namespace FirstOne.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public Grade? Grade { get; set; }

        public int CourseId { get; set; }

        [Display(Name = "Course")]
        public virtual Course Course { get; set; }

        public int StudentID { get; set; }

        [Display(Name = "Student")]
        public virtual Student Student { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}
