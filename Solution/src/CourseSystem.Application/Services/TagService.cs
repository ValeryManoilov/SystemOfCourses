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
    public class TagService : ITagService, IApplicationService
    {
        private readonly IRepository<Tag, Guid> _tagRepository;

        public TagService(IRepository<Tag, Guid> tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<List<TagDto>> GetAllTags()
        {
            var AllTags = await _tagRepository.GetListAsync();
            return AllTags.Select(t => new TagDto
            {
                TagName = t.TagName,
                TagLessons = t.TagLessons.Select(l => new LessonDto
                {
                    CourseId = l.CourseId,
                    LessonCourse = new CourseDto
                    {
                        CourseName = l.LessonCourse.CourseName,
                        Description = l.LessonCourse.Description
                    },
                    Route = l.Route,
                    Description = l.Description,
                    Date = l.Date
                }).ToList()
            }).ToList();
        }

        public async Task<TagDto> CreateTag(TagDto newTag)
        {
            var newTagItem = await _tagRepository.InsertAsync(
                new Tag
                {
                    Id = Guid.NewGuid(),
                    TagName = newTag.TagName,
                }
            );

            TagDto newTagItemDto = new TagDto
            {
                TagName = newTagItem.TagName,
            };

            return newTagItemDto;

        }
        public async Task DeleteTag(Guid id)
        {
            await _tagRepository.DeleteAsync(id);
        }
    }
}
