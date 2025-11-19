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
    public class TagsRepository : ITagsRepository
    {

        private readonly HomeworKZDbContext _context;

        public TagsRepository( HomeworKZDbContext context )
        {

            _context = context;

        }

        //GETALL
        //Get all tags
        public async Task<List<Tags>> GetAllAsync()
        {
            return await _context.Tags.ToListAsync();
        }

        //GETBYID
        //Get tag by id
        public async Task<Tags?> GetByIdAsync(int id)
        {
            return await _context.Tags.FindAsync(id);
        }

        //CREATE
        //Create new tag
        public async Task<Tags> CreateAsync( Tags tag )
        {
            _context.Tags.Add( tag );
            await _context.SaveChangesAsync();
            return tag;
        }

        //UPDATE
        //Update existing tag
        public async Task<Tags> UpdateAsync( Tags tag )
        {
            _context.Tags.Update( tag );
            await _context.SaveChangesAsync();
            return tag;
        }

        //DELETE
        //Delete existng tag
        public async Task<bool> DeleteAsync( Tags tag)
        {
            _context.Tags.Remove( tag );
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
