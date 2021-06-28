using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace s2Lab4.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LectureId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public DateTime date { get; set; }
        [Required]
        public Category category { get; set; }

        public byte CategoryId { get; set; }

    }
   
}