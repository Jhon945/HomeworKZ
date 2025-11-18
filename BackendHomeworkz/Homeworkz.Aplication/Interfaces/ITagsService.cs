using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Aplication.DTOs.Tags;

namespace Homeworkz.Aplication.Interfaces
{
    public interface ITagsService
    {

        Task<TagsCreateDto> CreateAsync(TagsCreateDto dto);

        Task<TagsUpdateDto> UpdateAsync(TagsUpdateDto dto);

        Task<bool> DeleteAsync (int id);

        Task<TagsGetDto> GetAllAsync();

        Task<TagsGetDto> GetByIdAsync (int id);

        Task<TagsGetDto> GetByTaskIdAsync(int taskId);

        Task<TagsGetDto> GetByProjectIdAsync (int projectId);

    }
}
