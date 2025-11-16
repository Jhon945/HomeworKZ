using System;
using Homeworkz.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Homeworkz.Domain.Entities
{

    [Index(nameof(Name) ,IsUnique = true)]

    public class Projects
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public ProjectStatus Status { get; set; } = ProjectStatus.Created; 
        
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt {  get; set; }

        [Required]
        public int OwnerId { get; set; }
        public required Users Owner { get; set; } = null!;



        // Relacion N-N projectMembers
        public ICollection<ProjectMembers> ProjectMembers { get; set; } = new List<ProjectMembers>();

        // Relacion 1-N Tasks(ProjectId)
        public ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();

    }
}
