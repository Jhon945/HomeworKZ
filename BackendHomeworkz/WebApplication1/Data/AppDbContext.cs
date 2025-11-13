using Homeworkz.Models;
using Microsoft.EntityFrameworkCore;
using Homeworkz.Models;

namespace Homeworkz.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }

    }
}
