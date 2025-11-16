using Homeworkz.Models;
using Microsoft.EntityFrameworkCore;

namespace Homeworkz.Data
{
    public class HomeworKZDbContext : DbContext
    {
        public HomeworKZDbContext(DbContextOptions<HomeworKZDbContext> options)
            : base(options) { }

        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<ProjectMembers> ProjectMembers { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolesPermissions> RolesPermissions { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<TagsTasks> TagsTasks { get; set; }
        public DbSet<TaskAttachments> TaskAttachments { get; set; }
        public DbSet<TaskComments> TaskComments { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsersRoles>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<RolesPermissions>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            modelBuilder.Entity<ProjectMembers>()
                .HasKey(pm => new { pm.ProjectId, pm.UserId });

            modelBuilder.Entity<TagsTasks>()
                .HasKey(tt => new { tt.TaskId, tt.TagId });

            modelBuilder.Entity<Projects>()
                .HasOne(p => p.Owner)
                .WithMany()
                .HasForeignKey(p => p.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProjectMembers>()
                .HasOne(pm => pm.Project)
                .WithMany()
                .HasForeignKey(pm => pm.ProjectId);

            modelBuilder.Entity<ProjectMembers>()
                .HasOne(pm => pm.User)
                .WithMany()
                .HasForeignKey(pm => pm.UserId);

            modelBuilder.Entity<TaskComments>()
                .HasOne(tc => tc.Task)
                .WithMany(t => t.TaskComments)
                .HasForeignKey(tc => tc.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TaskComments>()
                .HasOne(tc => tc.User)
                .WithMany(u => u.TaskComments)
                .HasForeignKey(tc => tc.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Tasks>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.AssignedTo)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
