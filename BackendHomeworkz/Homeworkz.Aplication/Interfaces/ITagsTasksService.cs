using Homeworkz.Aplication.DTOs.TagsTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.Interfaces
{
    public interface ITagsTasksService
    {

        Task<TagsTasksDto> CreateAsync(TagsTasksDto dto);

        Task<bool> DeleteAsync(int id);

        Task<TagsTasksDto> GetAllAsync();

        Task<TagsTasksDto> GetByTagIdAsync(int tagId);

        Task<TagsTasksDto> GetByTaskIdAsync(int taskId);

    }
}
