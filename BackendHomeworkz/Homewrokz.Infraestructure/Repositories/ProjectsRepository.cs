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
    public class ProjectsRepository : IProjectsRepository
    {

        private readonly HomeworKZDbContext _context;

        public ProjectsRepository( HomeworKZDbContext context)
        {

            _context = context;

        }

        //GETALL
        //Get all projects
        public async Task<List<Projects>> GetAllAsync()
        {
            return await _context.Projects.ToListAsync();
        } 

        //GETBYID
        //Get project by id
        public async Task<Projects?> GetByIdAsync(int id)
        {
            return await _context.Projects.FindAsync(id);
        }

        //GETBYOWNERID
        //Get all projects by ownerid
        public async Task<List<Projects>> GetByOwnerIdAsync(int ownerId)
        {
            return await _context.Projects
                .Where(p => p.OwnerId == ownerId)
                .ToListAsync();
        }

        //CREATE
        //Create new project
        public async Task<Projects> CreateAsync(Projects project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return project;
        }

        //UPDATE
        //Update existing project
        public async Task<Projects> UpdateAsync(Projects project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
            return project;
        } 

        //DELETE
        //Delete existing project
        public async Task<bool> DeleteAsync(Projects project)
        {
            _context.Projects.Remove(project);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
