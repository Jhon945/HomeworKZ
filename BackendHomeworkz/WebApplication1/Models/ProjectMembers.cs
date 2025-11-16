using System;
using Homeworkz.Enums;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Models
{
    public class ProjectMembers
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int ProjectId { get; set; }
        public Projects Project { get; set; } = null!;

        [Required]
        public ProjectMembersRoles RolProject {  get; set; }

        [Required]
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public DateTime? LeftAt {  get; set; }

        [Required]
        public int UserId { get; set; }
        public Users User { get; set; } = null!;
    }
}
