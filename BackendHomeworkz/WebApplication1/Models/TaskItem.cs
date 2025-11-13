using System;

namespace Homeworkz.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; } = "To Do";
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Project? Project { get; set; }
    }
}
