using Homeworkz.Aplication.DTOs.TasksAttachments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.Interfaces
{
    public interface ITasksAttachmentsService
    {

        Task<TasksAttachmentsGetDto> CreateAsync(TasksAttachmentsCreateDto dto);

        Task<bool> DeleteAsync(int id);

        Task<TasksAttachmentsGetDto> GetAllAsync();

        Task<TasksAttachmentsGetDto> GetByIdAsync(int id);

        Task<TasksAttachmentsGetDto> GetByTaskIdAsync(int id);

    }
}
