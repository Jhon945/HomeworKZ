using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Aplication.DTOs.Projects;

namespace Homeworkz.Aplication.Interfaces
{
    public interface IProjectsService
    {

        Task<ProjectsGetDto> CreateAsync(ProjectsCreateDto dto);

        Task<ProjectsGetDto> UpdateAsync(ProjectsUpdateDto dto);

        Task<bool> DeleteAsync(int id);

        Task<ProjectsGetDto> GetAsync();

        Task<ProjectsGetDto> GetByIdAsync(int id);

        Task<ProjectsGetDto> GetByOwnerId(int ownerId);

    }
}
