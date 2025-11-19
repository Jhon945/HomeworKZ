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
    public class TasksCommentsRepository : ITasksCommentsRepository
    {

        private readonly HomeworKZDbContext _context;

        public TasksCommentsRepository( HomeworKZDbContext context)
        {

            _context = context;

        }

        //GETALL
        //Get all comments of tasks
        public  async Task<List<TaskComments>> GetAllAsync()
        {
            return await _context.TaskComments.ToListAsync();
        }

        //GETBYID
        //Get comment of task by id
        public async Task<TaskComments?> GetByIdAsync(int id)
        {
            return await _context.TaskComments.FindAsync(id);
        }

        //GETBYTASKID
        //Get all comments of task by taskid
        public async Task<List<TaskComments>> GetByTaskIdAsync(int taskId)
        {
            return await _context.TaskComments
                .Where(tc => tc.TaskId == taskId)
                .ToListAsync();
        }

        //GETBYUSERID
        //Get all comments of task by userid
        public async Task<List<TaskComments>> GetByUserIdAsync(int userId)
        {
            return await _context.TaskComments
                .Where(tc => tc.UserId == userId)
                .ToListAsync();
        }


        //CREATE
        //Create new comment by task
        public async Task<TaskComments> CreateAsync(TaskComments taskComment)
        {
            _context.TaskComments.Add(taskComment);
            await _context.SaveChangesAsync();
            return taskComment;
        }


        //UPDATE
        //Update exisiting comment of task
        public async Task<TaskComments> UpdateAsync(TaskComments taskComment)
        {
            _context.TaskComments.Update(taskComment);
            await _context.SaveChangesAsync();
            return taskComment;
        }

        //DELETE
        //Delete existing comment of task
        public async Task<bool> DeleteAsync(TaskComments taskComment)
        {
            _context.TaskComments.Remove(taskComment);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
