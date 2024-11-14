using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CourseSystem.Models
{
    public class LessonTag : AuditedAggregateRoot<Guid>
    {
        public Guid LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
