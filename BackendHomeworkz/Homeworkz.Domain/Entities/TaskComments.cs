using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Domain.Entities
{
    public class TaskComments
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength]
        public string Comment { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public int TaskId { get; set; }
        public Tasks Task { get; set; } = null!;

        [Required]
        public int UserId { get; set; }
        public Users User { get; set; } = null!;
    }
}
