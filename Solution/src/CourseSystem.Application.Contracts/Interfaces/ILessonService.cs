using CourseSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem.Interfaces
{
    public interface ILessonService
    {
        Task<List<LessonDto>> GetAllLessons();
        Task<LessonDto> CreateLesson(LessonDto newLesson);
        Task DeleteLesson(Guid id);
    }
}
