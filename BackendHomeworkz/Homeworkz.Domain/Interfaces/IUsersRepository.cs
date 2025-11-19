using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface IUsersRepository
    {

        Task<Users?> GetByIdAsync(int id);

        Task<List<Users>> GetAllAsync();

        Task<Users> CreateAsync(Users user);

        Task<Users> UpdateAsync(Users user);

        Task<bool> DeleteAsync(Users user);

    }
}
