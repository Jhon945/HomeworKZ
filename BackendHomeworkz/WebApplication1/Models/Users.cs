using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Homeworkz.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(Phone), IsUnique = true)]
    [Index(nameof(Username), IsUnique = true)]

    public class Users
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string Lastname { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string Password { get; set; } = string.Empty; //hay que dejarlo hash

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



        // Relacion N-N UsersRoles
        public ICollection<UsersRoles> UsersRoles { get; set; } = new List<UsersRoles>();

        // Relacion N-N ProjectMembers
        public ICollection<ProjectMembers> ProjectMembers { get; set; } = new List<ProjectMembers>();

        // Relacion 1-N Projects(OwnerId)
        public ICollection<Projects> Projects { get; set; } = new List<Projects>();

        // Relacion 1-N Notifications(UserId)
        public ICollection<Notifications> Notifications { get; set; } = new List<Notifications>();

        // Relacion 1-N Task(AssignedTo)
        public ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();

        // Relacion 1-N TaskComments(UserId)
        public ICollection<TaskComments> TaskComments { get; set; } = new List<TaskComments>();

    }
}
