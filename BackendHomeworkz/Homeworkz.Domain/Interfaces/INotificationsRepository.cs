using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;

namespace Homeworkz.Domain.Interfaces
{
    public interface INotificationsRepository
    {

        Task<List<Notifications>> GetAllAsync();

        Task<Notifications?> GetByIdAsync(int id);

        Task<List<Notifications>> GetByUserIdAsync(int userId);

        Task<Notifications> CreateAsync(Notifications notification);

        Task<Notifications> UpdateAsync(Notifications notification);

        Task<bool> DeleteAsync(Notifications notification);

    }
}
