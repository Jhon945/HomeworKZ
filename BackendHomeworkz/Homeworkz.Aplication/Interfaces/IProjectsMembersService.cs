using Homeworkz.Aplication.DTOs.ProjectsMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.Interfaces
{
    internal interface IProjectsMembersService
    {

        Task<ProjectsMembersGetDto> CreateAsync(ProjectsMembersGetDto dto);

        Task<ProjectsMembersGetDto> UpdateAsync(ProjectsMembersGetDto dto);

        Task<bool> DeleteAsync(int id);

        Task<ProjectsMembersGetDto> GetAllAsync();

        Task<ProjectsMembersGetDto> GetByIdAsync(int id);

        Task<ProjectsMembersGetDto> GetByUserId(int userId);

        Task<ProjectsMembersGetDto> GetByProjectId(int projectId);

    }
}
