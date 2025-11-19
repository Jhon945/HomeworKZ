using Homeworkz.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworkz.Domain.Entities;
using Homeworkz.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Homeworkz.Infraestructure.Repositories
{
    public class TasksAttachmentsRepository : ITasksAttachmentsRepository
    {

        private readonly HomeworKZDbContext _context;

        public TasksAttachmentsRepository( HomeworKZDbContext context )
        {

            _context = context; 

        } 

        //GETALL
        //Get all attachments of tasks
        public async Task<List<TaskAttachments>> GetAllAsync()
        {
            return await _context.TaskAttachments.ToListAsync();
        }

        //GETBYID
        //Get attachment by id
        public async Task<TaskAttachments?> GetByIdAsync(int id)
        {
            return await _context.TaskAttachments.FindAsync( id );
        }

        //GETBYTASKID
        //Get all attachments by taskid
        public async Task<List<TaskAttachments>> GetByTaskIdAsync(int taskId)
        {
            return await _context.TaskAttachments
                .Where( ta => ta.TaskId == taskId )
                .ToListAsync();
        }

        //CREATE
        //Create new field of attachment 
        public async Task<TaskAttachments> CreateAsync(TaskAttachments taskAttachment)
        {
            _context.TaskAttachments.Add( taskAttachment );
            await _context.SaveChangesAsync();
            return taskAttachment;
        }

        //DELETE
        //Delete exisiting attachment of task
        public async Task<bool> DeleteAsync(TaskAttachments taskAttachment)
        {
            _context.TaskAttachments.Remove(taskAttachment);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
