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
    public class TagsTasksRepository : ITagsTasksRepository
    {

        private readonly HomeworKZDbContext _context;

        public TagsTasksRepository( HomeworKZDbContext context)
        {

            _context = context;

        }

        //GETALL
        //Get all tagstasks
        public async Task<List<TagsTasks>> GetAllAsync()
        {
            return await _context.TagsTasks.ToListAsync();
        }

        //GETBYTAGID
        //Get all taks by tagid
        public async Task<List<TagsTasks>> GetByTagIdAsync(int tagId)
        {
            return await _context.TagsTasks
                    .Where(tt => tt.TagId == tagId)
                    .ToListAsync();
        }

        //GETBYTASKID
        //Get all tags by taskid
        public async Task<List<TagsTasks>> GetByTaskId(int taskId)
        {
            return await _context.TagsTasks
                .Where(tt => tt.TaskId == taskId)
                .ToListAsync();
        }

        //CREATE
        //Create new field for relation N-N (User-Rol)
        public async Task<TagsTasks> CreateAsync(TagsTasks tagsTasks)
        {
            _context.TagsTasks.Add(tagsTasks);
            await _context.SaveChangesAsync();
            return tagsTasks;
        }

        //DELETE
        //Delete existing field
        public async Task<bool> DeleteAsync(TagsTasks tagsTasks)
        {
            _context.TagsTasks.Remove(tagsTasks);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
