using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Aplication.DTOs.Tasks;

namespace Homeworkz.Aplication.Interfaces
{
    internal interface ITasksService
    {

        Task<TasksGetDto> CreateAsync(TasksCreateDto dto);

        Task<TasksGetDto> UpdateAsync(TasksUpdateDto dto);

        Task<bool> DeleteAsync(int id);

        Task<TasksGetDto> GetAllAsync();

        Task<TasksGetDto> GetByIdAsync(int id);

        Task<TasksGetDto> GetByProjectId(int projectId);

    }
}
