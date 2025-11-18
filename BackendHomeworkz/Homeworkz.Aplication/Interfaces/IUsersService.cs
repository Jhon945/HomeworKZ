using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Aplication.DTOs;
using Homeworkz.Aplication.DTOs.Users;

namespace Homeworkz.Aplication.Interfaces
{
    public interface IUsersService
    {

        Task<UsersGetDto> CreateAsync(UsersCreateDto dto);

        Task<UsersGetDto> UpdateAsync(UsersUpdateDto dto);

        Task<bool> DeleteAsync(int id);

        Task<UsersGetDto> GetByIdAsync(int id);

        Task<List<UsersGetDto>> GetAllAsync();

        Task<UsersLoginResponseDto> LoginAsync(UsersLoginDto login);

    }
}
