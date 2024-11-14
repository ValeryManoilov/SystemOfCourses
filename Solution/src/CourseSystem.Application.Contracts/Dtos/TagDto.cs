using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseSystem.Dtos
{
    public class TagDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string TagName { get; set; }

        public virtual ICollection<LessonDto> TagLessons { get; set; } = new List<LessonDto>();
    }
}
