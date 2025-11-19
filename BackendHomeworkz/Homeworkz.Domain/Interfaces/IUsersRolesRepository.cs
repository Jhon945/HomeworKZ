using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface IUsersRolesRepository
    {

        Task<List<UsersRoles>> GetAllAsync();

        Task<List<UsersRoles>> GetByUserIdAsync(int userId);

        Task<List<UsersRoles>> GetByRolIdAsync(int rolId);

        Task<UsersRoles> CreateAsync(UsersRoles usersRoles);

        Task<bool> DeleteAsync(UsersRoles usersRoles);

    }
}
