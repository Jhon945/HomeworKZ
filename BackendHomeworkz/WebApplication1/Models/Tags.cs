using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Models
{
    public class Tags
    {

        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength]
        public string Name { get; set; } = string.Empty;

        [StringLength(150)]
        public string Color { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        // Relacion N-N TagsTasks(TagId)
        public ICollection<TagsTasks> TagsTasks { get; set; } = new List<TagsTasks>();

    }
}
