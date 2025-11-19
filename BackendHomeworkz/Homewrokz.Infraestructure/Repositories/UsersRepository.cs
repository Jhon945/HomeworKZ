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
    public class UsersRepository : IUsersRepository
    {

        private readonly HomeworKZDbContext _context;

        public UsersRepository( HomeworKZDbContext context) 
        {

            _context = context;

        }

        //GETALL
        //Get all users
        public async Task<List<Users>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        //GETBYID
        //Get user by id
        public async Task<Users?> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        //CREATE
        //Create new user
        public async Task<Users> CreateAsync(Users user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        //UPDATE
        //Update exisitng user
        public async Task<Users> UpdateAsync(Users user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        //DELETE
        //Delete exisiting User
        public async Task<bool> DeleteAsync(Users user)
        {
            _context.Users.Remove(user);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
