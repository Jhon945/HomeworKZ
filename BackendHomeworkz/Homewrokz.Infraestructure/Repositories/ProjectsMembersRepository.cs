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
    public class ProjectsMembersRepository : IProjectsMembersRepository
    {

        private readonly HomeworKZDbContext _context;

        public ProjectsMembersRepository(HomeworKZDbContext context)
        {

            _context = context;

        }

        //GETALL
        //Get all projectsmembers
        public async Task<List<ProjectMembers>> GetAllAsync()
        {
            return await _context.ProjectMembers.ToListAsync();
        }

        //GETBYID
        //Get by projectmember by id
        public async Task<ProjectMembers?> GetByIdAsync(int id)
        {
            return await  _context.ProjectMembers.FindAsync(id);
        }

        //GETBYPROJECTID
        //Get all members of project by project id
        public async Task<List<ProjectMembers>> GetByProjectIdAsync(int projectId)
        {
            return await _context.ProjectMembers
                .Where(pm => pm.ProjectId == projectId)
                .ToListAsync();
        }

        //GETBYUSERID
        //Get all projects contain the user by userid
        public async Task<List<ProjectMembers>> GetByUserIdASync(int userId)
        {
            return await _context.ProjectMembers
                .Where(pm => pm.UserId == userId)
                .ToListAsync();
        }

        //CREATE
        //Add new user at project
        public async Task<ProjectMembers> CreateAsync(ProjectMembers projectMember)
        {
            _context.ProjectMembers.Add(projectMember);
            await _context.SaveChangesAsync();
            return projectMember;
        }

        //UPDATE
        //Update existing projectmember
        public async Task<ProjectMembers> UpdateAsync(ProjectMembers projectMember)
        {
            _context.ProjectMembers.Update(projectMember);
            await _context.SaveChangesAsync();
            return projectMember;
        }

        //DELETE
        //Delete existing projectmember
        public async Task<bool> DeleteAsync(ProjectMembers projectMember)
        {
            _context.ProjectMembers.Remove(projectMember);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
