using CourseSystem.Dtos;
using CourseSystem.Interfaces;
using CourseSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CourseSystem.Services
{
    public class LessonService : ILessonService, IApplicationService
    {
        private readonly IRepository<Lesson, Guid> _lessonRepository;

        public LessonService(IRepository<Lesson, Guid> lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<List<LessonDto>> GetAllLessons()
        {
            var AllLessons = await _lessonRepository.GetListAsync();
            return AllLessons.Select(l => new LessonDto
            {
                CourseId = l.CourseId,
                LessonCourse = new CourseDto
                {
                    CourseName = l.LessonCourse.CourseName,
                    Description = l.LessonCourse.Description
                },
                Date = l.Date,
                Route = l.Route,
                Description = l.Description,
                LessonTags = l.LessonTags.Select(t => new TagDto
                {
                    TagName = t.TagName
                }).ToList()
            }).ToList();
        }

        public async Task<LessonDto> CreateLesson(LessonDto newLesson)
        {
            var newCourseItem = await _lessonRepository.InsertAsync(
                new Lesson
                {
                    CourseId = newLesson.CourseId,
                    LessonCourse = new Course
                    {
                        CourseName = newLesson.LessonCourse.CourseName,
                        Description = newLesson.LessonCourse.Description
                    },
                    Date = newLesson.Date,
                    Route = newLesson.Route,
                    Description = newLesson.Description,
                }
            );

            LessonDto newLessonItemDto = new LessonDto
            {
                CourseId = newLesson.CourseId,
                LessonCourse = new CourseDto
                {
                    CourseName = newLesson.LessonCourse.CourseName,
                    Description = newLesson.LessonCourse.Description
                },
                Date = newLesson.Date,
                Route = newLesson.Route,
                Description = newLesson.Description,
            };

            return newLessonItemDto;

        }
        public async Task DeleteLesson(Guid id)
        {
            await _lessonRepository.DeleteAsync(id);
        }
    }
}
