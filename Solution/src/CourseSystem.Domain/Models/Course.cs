using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CourseSystem.Models
{
    public class Course : AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
