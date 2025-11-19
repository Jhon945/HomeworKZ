using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface ITagsTasksRepository
    {

        Task<List<TagsTasks>> GetAllAsync();

        Task<List<TagsTasks>> GetByTagIdAsync(int tagId);

        Task<List<TagsTasks>> GetByTaskIdAsync(int taskId);

        Task<TagsTasks> CreateAsync(TagsTasks tagsTasks);

        Task<bool> DeleteAsync(TagsTasks tagsTasks);
         
    }
}
