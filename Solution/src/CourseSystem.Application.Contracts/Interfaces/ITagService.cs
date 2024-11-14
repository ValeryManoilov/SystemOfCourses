using CourseSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace CourseSystem.Interfaces
{
    public interface ITagService : IApplicationService
    {
        Task<List<TagDto>> GetAllTags();
        Task<TagDto> CreateTag(TagDto newTag);
        Task DeleteTag(Guid id);
    }
}
