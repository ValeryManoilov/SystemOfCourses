using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourseSystem.Dtos
{
    public class LessonDto
    {
        public Guid CourseId { get; set; }

        public CourseDto LessonCourse { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(200)]
        public string Route { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }
        
        public virtual ICollection<TagDto> LessonTags { get; set; } = new List<TagDto>();
    }
}
