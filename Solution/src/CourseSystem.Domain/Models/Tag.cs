using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CourseSystem.Models
{
    public class Tag : AuditedAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string TagName { get; set; }
        public virtual ICollection<Lesson> TagLessons { get; set; } = new List<Lesson>();
    }
}
