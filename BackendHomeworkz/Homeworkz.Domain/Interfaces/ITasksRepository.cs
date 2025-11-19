using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface ITasksRepository
    {

        Task<List<Tasks>> GetAllAsync();

        Task<Tasks?> GetByIdAsync(int id);

        Task<List<Tasks>> GetByProjectIdAsync(int projectId);

        Task<Tasks> CreateAsync(Tasks task);

        Task<Tasks> UpdateAsync(Tasks task);

        Task<bool> DeleteAsync(Tasks task);
        
    }
}
