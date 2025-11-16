using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Models
{
    public class Notifications
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength]
        public string Message { get; set; } = string.Empty;

        [Required]
        public bool IsRead { get; set; } = false;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public int UserId { get; set; }
        public Users User { get; set; } = null!;

    }
}
