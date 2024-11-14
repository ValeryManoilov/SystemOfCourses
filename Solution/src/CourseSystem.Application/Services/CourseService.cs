using CourseSystem.Dtos;
using CourseSystem.Models;
using CourseSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CourseSystem.Services
{
    public class CourseService : ICourseService, IApplicationService
    {
        private readonly IRepository<Course, Guid> _courseRepository;

        public CourseService(IRepository<Course, Guid> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<List<CourseDto>> GetAllCourses()
        {
            var AllCourses = await _courseRepository.GetListAsync();
            var AllCoursesSelected = AllCourses.Select(c => new CourseDto
            {
                CourseName = c.CourseName,
                Description = c.Description,
                Lessons = c.Lessons.Select(l =>
                new LessonDto
                {
                    CourseId = c.Id,
                    LessonCourse = new CourseDto
                    {
                        CourseName = l.LessonCourse.CourseName,
                        Description = l.LessonCourse.Description,
                    },
                    Date = l.Date,
                    Route = l.Route,
                    Description = l.Description,
                    LessonTags = l.LessonTags.Select(t => new TagDto
                    {
                        TagName = t.TagName
                    }).ToList()
                }).ToList()
            }).ToList();

            return AllCoursesSelected;
        }

        public async Task<CourseDto> CreateCourse(CourseDto newCourse)
        {
            await _courseRepository.InsertAsync(
                new Course
                {
                    Id = Guid.NewGuid(),
                    CourseName = "Test123",
                    Description = "Test123"
                });

            var newCourseItem = await _courseRepository.InsertAsync(
                new Course
                {
                    Id = Guid.NewGuid(),
                    CourseName = newCourse.CourseName,
                    Description = newCourse.Description,
                }
            );

            CourseDto newCourseItemDto = new CourseDto
            {
                CourseName = newCourseItem.CourseName,
                Description = newCourseItem.Description,
            };

            return newCourseItemDto;

        }
        public async Task DeleteCourse(Guid id)
        {
            await _courseRepository.DeleteAsync(id);
        }
    }
}
