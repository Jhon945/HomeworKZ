using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface IProjectsMembersRepository
    {

        Task<List<ProjectMembers>> GetAllAsync();

        Task<ProjectMembers?> GetByIdAsync(int id);

        Task<List<ProjectMembers>> GetByProjectIdAsync(int projectId);

        Task<List<ProjectMembers>> GetByUserIdAsync(int userId);
        
        Task<ProjectMembers> CreateAsync(ProjectMembers projectMembers);

        Task<ProjectMembers> UpdateAsync(ProjectMembers projectMembers);

        Task<bool> DeleteAsync(ProjectMembers projectMembers);

    }
}
