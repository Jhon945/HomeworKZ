using System;
using Homeworkz.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Domain.Entities
{
    public class Tasks
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; } = string.Empty;

        [MaxLength]
        public string? Description { get; set; }

        [Required]
        public StatusTask Status { get; set; } = StatusTask.Blacklog;

        [Required]
        public PriorityTask Priority { get; set; }

        public DateTime? DueDate { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public int? AssignedTo { get; set; }
        public Users User { get; set; } = null!;

        [Required]
        public int ProjectId { get; set; }
        public Projects Project {  get; set; } = null!;



        // Relacion N-N TagsTasks(TaskId)
        public ICollection<TagsTasks> TagsTasks { get; set; } = new List<TagsTasks>();

        // Relacion 1-N TaskAttachments(TaskId)
        public ICollection<TaskAttachments> TaskAttachments { get; set; } = new List<TaskAttachments>();

        // Relacion 1-N TaskComments(TaskId)
        public ICollection<TaskComments> TaskComments { get; set; } = new List<TaskComments>();

    }
}
