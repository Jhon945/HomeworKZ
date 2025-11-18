using Homeworkz.Aplication.DTOs.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.Interfaces
{
    public interface INotificationsService
    {

        Task<NotificationsGetDto> CreateAsync(NotificationsCreateDto dto);

        Task<bool> DeleteAsync(int id);

        Task<NotificationsGetDto> GetAllAsync();

        Task<NotificationsGetDto> GetByIdAsync(int id);

        Task<NotificationsGetDto> GetByUserIdAsync(int userId);
    }
}
