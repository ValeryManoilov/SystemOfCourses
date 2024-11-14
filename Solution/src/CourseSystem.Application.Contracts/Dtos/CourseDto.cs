using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CourseSystem.Dtos
{
    public class CourseDto
    {
        [Required]
        [MaxLength(200)]
        public string CourseName { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<LessonDto> Lessons { get; set; } = new List<LessonDto>();
    }
}
