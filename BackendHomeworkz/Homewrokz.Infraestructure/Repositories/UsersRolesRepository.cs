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
    public class UsersRolesRepository : IUsersRolesRepository
    {

        private readonly HomeworKZDbContext _context;

        public UsersRolesRepository( HomeworKZDbContext context) 
        {

            _context = context;

        }

        //GETALL
        //Get all usersroles
        public async Task<List<UsersRoles>> GetAllAsync()
        {
            return await _context.UsersRoles.ToListAsync();
        }

        //GETBYUSERID
        //Get all roles by userid
        public async Task<List<UsersRoles>>  GetByUserIdAsync(int userId)
        {
            return await _context.UsersRoles
                .Where(ur => ur.UserId == userId)
                .ToListAsync();
        }

        //GETBYROLID
        //Get all roles by rolid
        public async Task<List<UsersRoles>> GetByRolIdAsync(int rolId)
        {
            return await _context.UsersRoles
                .Where(ur => ur.RoleId == rolId)
                .ToListAsync();
        }

        //CREATE
        //Create new field for relation N-N (User-Rol)
        public async Task<UsersRoles> CreateAsync(UsersRoles usersRoles)
        {
            _context.UsersRoles.Add(usersRoles);
            await _context.SaveChangesAsync();
            return usersRoles;
        }

        //DELETE
        //Delete existing field
        public async Task<bool> DeleteAsync(UsersRoles usersRoles)
        {
            _context.UsersRoles.Remove(usersRoles);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
