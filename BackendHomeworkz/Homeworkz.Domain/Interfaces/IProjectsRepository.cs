using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface IProjectsRepository
    {

        Task<List<Projects>> GetAllAsync();

        Task<Projects?> GetByIdAsync(int id);

        Task<List<Projects>> GetByOwnerIdAsync(int ownerId);

        Task<Projects> CreateAsync(Projects project);

        Task<Projects> UpdateAsync(Projects project);

        Task<bool> DeleteAsync(Projects projects);

    }
}
