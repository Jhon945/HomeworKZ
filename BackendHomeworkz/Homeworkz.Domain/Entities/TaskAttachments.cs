using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Domain.Entities
{
    public class TaskAttachments
    {

        [Key]
        public int Id { get; set; }

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
