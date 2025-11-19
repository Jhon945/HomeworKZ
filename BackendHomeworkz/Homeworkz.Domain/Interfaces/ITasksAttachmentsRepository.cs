using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface ITasksAttachmentsRepository
    {

        Task<List<TaskAttachments>> GetAllAsync();

        Task<TaskAttachments?> GetByIdAsync(int id);

        Task<List<TaskAttachments>> GetByTaskIdAsync(int taskId);

        Task<TaskAttachments> CreateAsync(TaskAttachments taskAttachment);

        Task<bool> DeleteAsync(TaskAttachments taskAttachment);

    }
}
