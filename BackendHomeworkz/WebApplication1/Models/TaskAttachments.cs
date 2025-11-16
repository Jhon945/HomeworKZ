using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Models
{
    public class TaskAttachments
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength]
        public string FileName { get; set; } = string.Empty;

        [Required]
        [MaxLength]
        public string FilePath { get; set; } = string.Empty;

        [Required]
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public int TaskId { get; set; }
        public Tasks Task { get; set; } = null!;
    }
}
