using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstOne.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Provide the first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Provide the last name")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get => $"{FirstName} {LastName}"; }

        [Display(Name = "Enrollment Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Course Count")]
        [NotMapped]
        public int EnrollmentCount { get => Enrollments?.Count ?? 0; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
