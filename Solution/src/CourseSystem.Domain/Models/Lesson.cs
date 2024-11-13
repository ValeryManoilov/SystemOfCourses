using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CourseSystem.Models
{
    public class Lesson : AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Course LessonCourse { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Route { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Tag> LessonTags {  get; set; } = new List<Tag>();
    }
}
