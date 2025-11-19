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
    public class TasksRepository : ITasksRepository
    {

        private readonly HomeworKZDbContext _context;

        public TasksRepository( HomeworKZDbContext context)
        {

            _context = context;

        }
        
        //GETALL
        //Get all tasks
        public async Task<List<Tasks>> GetAllAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        //GETBYID
        //Get task by id
        public async Task<Tasks?> GetByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        //GETBYPROJECTID
        //Get all tasks by projectid
        public async Task<List<Tasks>> GetByProjectIdAsync(int projectId)
        {
            return await _context.Tasks
                .Where(t => t.ProjectId == projectId)
                .ToListAsync();
        }

        //CREATE
        //Create new task
        public async Task<Tasks> CreateAsync(Tasks task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        //UPDATE
        //Update existing task
        public async Task<Tasks> UpdateAsync(Tasks task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
            return task;
        }

        //DELETE
        //Delete existing task
        public async Task<bool> DeleteAsync(Tasks task)
        {
            _context.Tasks.Remove(task);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
