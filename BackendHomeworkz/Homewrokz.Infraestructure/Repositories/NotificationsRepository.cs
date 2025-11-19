using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;
using Homeworkz.Domain.Interfaces;
using Homeworkz.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Homeworkz.Infraestructure.Repositories
{
    public class NotificationsRepository : INotificationsRepository
    {

        private readonly HomeworKZDbContext _context;

        public NotificationsRepository( HomeworKZDbContext context)
        {

            _context = context;

        }

        //GETALL
        //Get all notifications
        public async Task<List<Notifications>> GetAllAsync()
        {
            return await _context.Notifications.ToListAsync();
        }

        //GETBYID
        //Get notification by id
        public async Task<Notifications?> GetByIdAsync(int id)
        {
            return await _context.Notifications.FindAsync(id);
        }

        //GETBYUSERID
        //Get all notifications send to user by userid
        public async Task<List<Notifications>> GetByUserIdAsync(int userId)
        {
            return await _context.Notifications
                .Where(n  => n.UserId == userId)
                .ToListAsync();
        }

        //CREATE
        //Create new notification
        public async Task<Notifications> CreateAsync(Notifications notification)
        {
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
            return notification;
        }

        //UPDATE
        //Update existing notification
        public async Task<Notifications> UpdateAsync(Notifications notification)
        {
            _context.Notifications.Update(notification);
            await _context.SaveChangesAsync();
            return notification;
        }

        //DELETE
        //Delete existing notification
        public async Task<bool> DeleteAsync(Notifications notification)
        {
            _context.Notifications.Remove(notification);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
