using Homeworkz.Aplication.DTOs.TasksComments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.Interfaces
{
    public interface ITasksCommentsService
    {

        Task<TasksCommentsGetDto> CreateAsync(TasksCommentsCreateDto dto);
        
        Task<TasksCommentsGetDto> UpdateAsync(TasksCommentsUpdateDto dto);

        Task<bool> DeleteAsync(int id);

        Task<TasksCommentsGetDto> GetAllAsync();

        Task<TasksCommentsGetDto> GetByIdAsync(int id);
        
        Task<TasksCommentsGetDto> GetByTaskId(int taskId);

        Task<TasksCommentsGetDto> GetByUserIdAsync(int userId);

    }
}
