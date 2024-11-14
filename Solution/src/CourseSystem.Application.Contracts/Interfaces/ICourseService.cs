using CourseSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseSystem.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<CourseDto>> GetAllCourses();
        Task<CourseDto> CreateCourse(CourseDto newCourse);
        Task DeleteCourse(Guid id);
    }
}
