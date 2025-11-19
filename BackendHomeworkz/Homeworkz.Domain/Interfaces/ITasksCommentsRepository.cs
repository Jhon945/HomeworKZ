using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface ITasksCommentsRepository
    {

        Task<List<TaskComments>> GetAllAsync();

        Task<TaskComments?> GetByIdAsync(int id);

        Task<List<TaskComments>> GetByTaskIdAsync(int taskId);

        Task<List<TaskComments>> GetByUserIdAsync(int userId);

        Task<TaskComments> CreateAsync(TaskComments taskComment);

        Task<TaskComments> UpdateAsync(TaskComments taskComment);

        Task<bool> DeleteAsync(TaskComments taskComment);

    }
}
