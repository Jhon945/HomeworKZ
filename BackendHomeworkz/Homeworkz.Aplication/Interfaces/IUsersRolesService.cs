using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Aplication.DTOs;
using Homeworkz.Aplication.DTOs.UsersRoles;

namespace Homeworkz.Aplication.Interfaces
{
    public interface IUsersRolesService
    {

        Task<UsersRolesDto> CreateAsync(UsersRolesDto dto);

        Task<bool> DeleteAsync(int id);

        Task<UsersRolesDto> GetAllAsync();

        Task<UsersRolesDto> GetByUserIdAsync(int userId);

        Task<UsersRolesDto> GetByRolIdAsync(int rolId);
    }
}
