using Homeworkz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.Tasks
{
    public class TasksCreateDto
    {

        [Required, StringLength(250)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public StatusTask Status { get; set; } = StatusTask.Blacklog;

        [Required]
        public PriorityTask Priority { get; set; }

        public int? AssignedTo { get; set; }

        [Required]
        public int ProjectId { get; set; }

    }
}
